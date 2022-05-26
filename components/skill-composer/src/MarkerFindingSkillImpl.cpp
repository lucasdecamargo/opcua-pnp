#include <MarkerFindingSkillImpl.h>

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

std::vector<std::shared_ptr<RegisteredSkill>> 
MarkerFindingSkillImpl::findRegisteredSKillByName(std::string name)
{
    std::vector<std::shared_ptr<RegisteredSkill>> found_skills;

    auto range = skillDetector->registeredSkills.equal_range(name);
    for(auto r = range.first; r != range.second; r++)
        found_skills.push_back(r->second);

    return found_skills;        
}

std::vector<MarkerFindingSkillImpl::CameraData> 
MarkerFindingSkillImpl::getCameraData(const std::vector<std::shared_ptr<RegisteredSkill>>& photoSkills)
{
    std::vector<MarkerFindingSkillImpl::CameraData> cameraData;

    std::map<std::shared_ptr<CameraData>, std::shared_future<bool>> skillCalls;
    using namespace std::chrono_literals;

    for(auto &s: photoSkills)
    {
        std::shared_ptr<CameraData> cam(new CameraData);
        cam->camera = s->getParentComponent();
        
        std::vector<std::shared_ptr<SkillParameter>> params;
        logger->trace("Executing PhotoSkill on endpoint URL: " + cam->camera->endpointUrl);
        try
        {
            skillCalls[cam] = s->execute(logger, loggerOpcUa, params).share();
        }
        catch(const std::exception& e)
        {
            logger->error("Could not execute PhotoSkill on endpoint URL: " + cam->camera->endpointUrl
                + ". Raised exception: " + std::string(e.what()));
        }        
    }

    while(!skillCalls.empty())
    {
        for(auto &s : skillCalls)
        {
            auto status = s.second.wait_for(250ms);
            if(status == std::future_status::ready)
            {
                logger->trace("Reading ImagePNG from endpoint URL: " + s.first->camera->endpointUrl);
                // Get ImagePNG NodeId and read the image from it.
                // Get CameraPose NodeId and read pose from it.

                skillCalls.erase(s.first);
            }
        }
    }

    return cameraData;
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
                = findRegisteredSKillByName("MarkerDetectionSkill");
            
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
            = findRegisteredSKillByName("PhotoSkill");
        
        if(photoSkills.empty())
        {
            logger->error("No camera node was found");
            return this->findingFinished();
        }


        ///////////////////////////
        // Populate camera data //
        /////////////////////////
        std::vector<CameraData> cameraData = getCameraData(photoSkills);

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
