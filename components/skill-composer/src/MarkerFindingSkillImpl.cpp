#include <MarkerFindingSkillImpl.h>

#include <client/SkillHelper.hpp>
#include <helper.hpp>

#include <types_pnp_types_generated_handling.h>

#include <chrono>

MarkerFindingSkillImpl::MarkerFindingSkillImpl(
    const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
    const std::shared_ptr<spdlog::logger>& logger,
    const std::shared_ptr<spdlog::logger>& loggerOpcUa,
    const std::shared_ptr<SkillDetector>& skillDetector,
    const libconfig::Setting& skillComposerSettings
)
  : pnp::opcua::skill::skill_composer::MarkerFindingSkillImpl(),
    server(server), logger(logger), loggerOpcUa(loggerOpcUa),
    skillDetector(skillDetector), skillComposerSettings(skillComposerSettings)
{
    // ...
}

std::vector<std::shared_ptr<MarkerFindingSkillImpl::CameraData>>
MarkerFindingSkillImpl::getCameraData(const std::vector<std::shared_ptr<RegisteredSkill>>& photoSkills)
{
    std::vector<std::shared_ptr<MarkerFindingSkillImpl::CameraData>> cameraData;

    std::map<std::shared_ptr<CameraData>, std::shared_future<bool>> skillCalls;
    using namespace std::chrono_literals;

    for(auto &s: photoSkills)
    {
        std::shared_ptr<CameraData> cam(new CameraData);
        cam->cameraClient = std::make_shared<CameraClient>(logger, loggerOpcUa, s);
        
        std::vector<std::shared_ptr<SkillParameter>> params;
        logger->trace("Executing PhotoSkill on endpoint URL: " + cam->cameraClient->getParentComponent()->endpointUrl);
        try
        {
            skillCalls[cam] = cam->cameraClient->execute(false).share();
        }
        catch(const std::exception& e)
        {
            logger->error("Could not execute PhotoSkill on endpoint URL: " + cam->cameraClient->getParentComponent()->endpointUrl
                + ". Raised exception: " + std::string(e.what()));
        }        
    }

    while(!skillCalls.empty())
    {
        for(auto &s : skillCalls)
        {
            if(s.second.wait_for(250ms) == std::future_status::ready)
            {
                if(!s.second.get())
                {
                    logger->error("PhotoSkill exeuction did not return to READY state for Camera endpoint: " 
                        + s.first->cameraClient->getParentComponent()->endpointUrl);
                    skillCalls.erase(s.first);
                    break;
                }

                logger->trace("Connecting to " + s.first->cameraClient->getParentComponent()->endpointUrl);
                s.first->cameraClient->connect();
                if(!s.first->cameraClient->ensureConnected())
                {
                    if(!s.first->cameraClient->connect()
                        || !s.first->cameraClient->ensureConnected())
                    {
                        logger->error("Could not get connect to Camera endpoint: " 
                            + s.first->cameraClient->getParentComponent()->endpointUrl);
                        skillCalls.erase(s.first);
                        break;
                    }
                }

                logger->trace("Getting NodeIds from camera endpoint " + s.first->cameraClient->getParentComponent()->endpointUrl);
                if(s.first->cameraClient->getNodeIds() != UA_STATUSCODE_GOOD)
                {
                    skillCalls.erase(s.first);
                    s.first->cameraClient->disconnect();
                    break;
                }

                logger->trace("Reading ImageNode from camera endpoint " + s.first->cameraClient->getParentComponent()->endpointUrl);
                if(s.first->cameraClient->readImageNode(&s.first->photo))
                {
                    skillCalls.erase(s.first);
                    s.first->cameraClient->disconnect();
                    break;
                }

                logger->trace("Reading CameraInfo from camera endpoint " + s.first->cameraClient->getParentComponent()->endpointUrl);
                s.first->cameraClient->readCameraInfoNode(&s.first->camInfo);
                logger->trace("Reading CameraPose from camera endpoint " + s.first->cameraClient->getParentComponent()->endpointUrl);
                s.first->cameraClient->readCameraPoseNode(&s.first->pose);

                s.first->cameraClient->disconnect();

                cameraData.push_back(s.first);
                skillCalls.erase(s.first);
            }
        }
    }

    return cameraData;
}

void MarkerFindingSkillImpl::detectMarkers(std::shared_ptr<RegisteredSkill> markerDetectionSkill, std::vector<std::shared_ptr<CameraData>> cameraData)
{
    ImageProcessorClient imageProcessorClient(logger, loggerOpcUa, markerDetectionSkill);

    if(!imageProcessorClient.connect()
        || !imageProcessorClient.ensureConnected())
    {
        logger->error("Could not get connect to ImageProcessor endpoint: " 
            + imageProcessorClient.getParentComponent()->endpointUrl);
        return;
    }

    imageProcessorClient.getNodeIds();

    for(auto &c : cameraData)
    {
        logger->trace("Executing MarkerDetectionSkill");
        if(!imageProcessorClient.execute(&c->photo, &c->camInfo, false).get())
        {
            logger->error("Could not execute MarkerDetectionSkill on endpoint "
                + imageProcessorClient.getParentComponent()->endpointUrl);
        }


        imageProcessorClient.readDetectedMarkersArrayNode(c->markers);
        
        // Only for debbuging purpouses
        for(auto &m: c->markers)
        {
            UA_MarkerDataType marker = m;
            int id = marker.id;
        }

        continue;
    }
}

bool MarkerFindingSkillImpl::start(std::vector<UA_MarkerDataType>& foundMarkers)
{
    logger->trace("MarkerFindingSkill called");

    std::thread t = std::thread([this, foundMarkers]()
    {
        ////////////////////////////////
        // Find image processor node //
        //////////////////////////////
        std::shared_ptr<RegisteredSkill> markerDetectionSkill;
        {
            std::vector<std::shared_ptr<RegisteredSkill>> skills
                = pnp::skill::findRegisteredSKillsByName(this->skillDetector, "MarkerDetectionSkill");
            
            if(skills.empty())
            {
                logger->error("No image processor node was found");
                return this->findingFinished();
            }
            else // use the head element
                markerDetectionSkill = skills.front();
        }

        logger->trace("Found image processor endpoint URL: "
                + markerDetectionSkill->getParentComponent()->endpointUrl);

        if(!markerDetectionSkill->getParentComponent()->connectClient()
            || !markerDetectionSkill->getParentComponent()->ensureConnected())
        {
            logger->error("Cannot connect to image processor endpoint URL: "
                + markerDetectionSkill->getParentComponent()->endpointUrl);
            return this->findingFinished();
        }

        
        ////////////////////////
        // Find camera nodes //
        //////////////////////
        std::vector<std::shared_ptr<RegisteredSkill>> photoSkills
            = pnp::skill::findRegisteredSKillsByName(this->skillDetector, "PhotoSkill");
        
        if(photoSkills.empty())
        {
            logger->error("No camera node was found");
            return this->findingFinished();
        }


        ///////////////////////////
        // Populate camera data //
        /////////////////////////
        std::vector<std::shared_ptr<MarkerFindingSkillImpl::CameraData>>
        cameraData = getCameraData(photoSkills);

        /////////////////////
        // Detect markers //
        ///////////////////
        detectMarkers(markerDetectionSkill, cameraData);

        for(auto &c : cameraData)
        {
            for(auto &m : c->markers)
                logger->info("Detected marker id " + std::to_string(m.id));
        }

        return this->findingFinished();
    });

    t.detach();

    return true;
}

bool MarkerFindingSkillImpl::halt()
{
    return false;
};

bool MarkerFindingSkillImpl::resume()
{
    return false;
};

bool MarkerFindingSkillImpl::suspend()
{
    return false;
};

bool MarkerFindingSkillImpl::reset()
{
    return false;
};
