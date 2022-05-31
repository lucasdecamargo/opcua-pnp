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

UA_NodeId MarkerFindingSkillImpl::getCameraParameterSetNodeId(std::shared_ptr<RegisteredSkill>& photoSkill)
{
    // Get ParameterSet NodeId
    UA_NodeId parameterSetNodeId;
    UA_UInt16 nsIdxDi;
    
    LockedClient lc = photoSkill->getParentComponent()->getLockedClient();
    UA_String nsUri = UA_String_fromChars(NAMESPACE_URI_DI);
    UA_StatusCode retval = UA_Client_NamespaceGetIndex(lc.get(), &nsUri, &nsIdxDi);
    UA_String_clear(&nsUri);
    if (retval != UA_STATUSCODE_GOOD) {
        throw std::runtime_error("Failed get namespace index for DI Namespace." + std::string(UA_StatusCode_name(retval)));
    }

    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        lc.get(), logger, photoSkill->getSkillControllerNodeId(),
        UA_QUALIFIEDNAME(nsIdxDi,
        const_cast<char *>("ParameterSet")),
        &parameterSetNodeId))
        throw std::runtime_error("Could not find Cameras ParameterSet NodeId");

    return parameterSetNodeId;
}

std::map<std::string, UA_NodeId> 
MarkerFindingSkillImpl::getCameraParametersNodeIds(std::shared_ptr<RegisteredSkill>& photoSkill)
{
    std::map<std::string, UA_NodeId> nodeIds;
    
    UA_NodeId parameterSetNodeId = getCameraParameterSetNodeId(photoSkill);
    UA_NodeId skillControllerNodeId = photoSkill->getSkillControllerNodeId();
    
    LockedClient lc = photoSkill->getParentComponent()->getLockedClient();
    UA_UInt16 nsIdxCamera;
    UA_String nsCamera = UA_String_fromChars("https://pnp.org/UA/Camera/");
    UA_StatusCode retval = UA_Client_NamespaceGetIndex(lc.get(), &nsCamera, &nsIdxCamera);
    UA_String_clear(&nsCamera);
    if (retval != UA_STATUSCODE_GOOD) {
        throw std::runtime_error("Failed get namespace index for Camera Namespace." + std::string(UA_StatusCode_name(retval)));
    }

    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        lc.get(), logger, skillControllerNodeId,
        UA_QUALIFIEDNAME(nsIdxCamera,
        const_cast<char *>("ImagePNG")),
        &nodeIds["ImagePNG"]))
        logger->error("Could not find ImagePNG NodeId");
    
    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        lc.get(), logger, parameterSetNodeId,
        UA_QUALIFIEDNAME(nsIdxCamera,
        const_cast<char *>("CameraInfo")),
        &nodeIds["CameraInfo"]))
        logger->error("Could not find CameraInfo NodeId");
    
    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        lc.get(), logger, parameterSetNodeId,
        UA_QUALIFIEDNAME(nsIdxCamera,
        const_cast<char *>("CameraPose")),
        &nodeIds["CameraPose"]))
        logger->error("Could not find CameraInfo NodeId");

    return nodeIds;
}

UA_StatusCode 
MarkerFindingSkillImpl::readCameraInfo(UA_Client* client, 
    UA_NodeId& cameraInfoNodeId, UA_CameraInfoDataType *data)
{
    UA_Variant v;
    UA_StatusCode ret = pnp::opcua::UA_Client_readVariable(client, cameraInfoNodeId, &v);
    if (ret != UA_STATUSCODE_GOOD)
    {
        logger->error("Cannot read camera info node: " + std::string(UA_StatusCode_name(ret)));
        return ret;
    }
    // if(((UA_ExtensionObject*)v.data)->content.decoded.type != &UA_TYPES[UA_TYPES_PNP_TYPES_CAMERAINFODATATYPE])
    // {
    //     const char* typeName = ((UA_ExtensionObject*)v.data)->content.decoded.type->typeName;
    //     UA_Variant_clear(&v);
    //     logger->error("Cannot read camera info node. Is not of type UA_CameraInfoDataType but of type "
    //         + std::string(typeName));

    //     return UA_STATUSCODE_BADTYPEMISMATCH;
    // }

    UA_ExtensionObject* extObj = static_cast<UA_ExtensionObject*>(v.data);

    ret = UA_ExtensionObject_setValueCopy(extObj, data, &UA_TYPES[UA_TYPES_PNP_TYPES_CAMERAINFODATATYPE]);

    // ret = UA_CameraInfoDataType_copy((UA_CameraInfoDataType*)v.data, data);
    
    if(ret == UA_STATUSCODE_GOOD)
    {
        if(data->distortionCoefficientsSize != 9 || data->cameraMatrixSize < 4)
        {
            logger->error("CameraInfo parameter sizes invalid");
            UA_Variant_clear(&v);
            return UA_STATUSCODE_BADBOUNDNOTSUPPORTED;
        }
        if(((UA_CameraInfoDataType*)v.data)->distortionCoefficients == NULL 
            || ((UA_CameraInfoDataType*)v.data)->cameraMatrix == NULL)
        {
            logger->error("CameraInfo values pointing to NULL");
            UA_Variant_clear(&v);
            return UA_STATUSCODE_BADSTRUCTUREMISSING;
        }
    }

    UA_Variant_clear(&v);

    return ret;
}

UA_StatusCode
MarkerFindingSkillImpl::readCameraPose(UA_Client* client, 
    UA_NodeId& cameraPoseNodeId, UA_PoseDataType *data)
{
    UA_Variant v;
    UA_StatusCode ret = pnp::opcua::UA_Client_readVariable(client, cameraPoseNodeId, &v);
    if (ret != UA_STATUSCODE_GOOD)
    {
        logger->error("Cannot read camera pose node: " + std::string(UA_StatusCode_name(ret)));
        return ret;
    }
    // if(v.type != &UA_TYPES[UA_TYPES_PNP_TYPES_POSEDATATYPE])
    // {
    //     const char* typeName = v.type->typeName;
    //     UA_Variant_clear(&v);
    //     logger->error("Cannot read camera pose node. Is not of type UA_PoseDataType but of type "
    //         + std::string(typeName));

    //     return UA_STATUSCODE_BADTYPEMISMATCH;
    // }

    ret = UA_ExtensionObject_setValueCopy((UA_ExtensionObject*)v.data, data, &UA_TYPES[UA_TYPES_PNP_TYPES_POSEDATATYPE]);

    // ret = UA_PoseDataType_copy((UA_PoseDataType*)v.data, data);

    UA_Variant_clear(&v);

    return ret;
}

UA_StatusCode MarkerFindingSkillImpl::readImagePNG(UA_Client* client, UA_NodeId& imageNodeId, UA_ImagePNG *image)
{

    UA_Variant v;
    UA_StatusCode ret = pnp::opcua::UA_Client_readVariable(client, imageNodeId, &v);
    if (ret != UA_STATUSCODE_GOOD)
    {
        logger->error("Cannot read image node: " + std::string(UA_StatusCode_name(ret)));
        return ret;
    }
    if(v.type != &UA_TYPES[UA_TYPES_IMAGEPNG] && v.type != &UA_TYPES[UA_TYPES_BYTESTRING])
    {
        const char* typeName = v.type->typeName;
        UA_Variant_clear(&v);
        logger->error("Cannot read image node. Is not of type ImagePNG but of type "
            + std::string(typeName));
        return ret;
    }

    logger->info("Read Image of TypeName: " + std::string(v.type->typeName));
    
    ret = UA_ImagePNG_copy((UA_ImagePNG*)v.data, image);

    UA_Variant_clear(&v);

    return ret;
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
        cam->photoSkill = s;
        
        std::vector<std::shared_ptr<SkillParameter>> params;
        logger->trace("Executing PhotoSkill on endpoint URL: " + cam->photoSkill->getParentComponent()->endpointUrl);
        try
        {
            skillCalls[cam] = s->execute(logger, loggerOpcUa, params).share();
        }
        catch(const std::exception& e)
        {
            logger->error("Could not execute PhotoSkill on endpoint URL: " + cam->photoSkill->getParentComponent()->endpointUrl
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
                        + s.first->photoSkill->getParentComponent()->endpointUrl);
                    skillCalls.erase(s.first);
                    break;
                }

                s.first->photoSkill->getParentComponent()->connectClient();

                if(!s.first->photoSkill->getParentComponent()->connectClient()
                    || !s.first->photoSkill->getParentComponent()->ensureConnected())
                {
                    logger->error("Could not get connect to Camera endpoint: " 
                        + s.first->photoSkill->getParentComponent()->endpointUrl);
                    skillCalls.erase(s.first);
                    break;
                }

                std::map<std::string, UA_NodeId> nodeIds;

                try
                {
                    nodeIds = getCameraParametersNodeIds(s.first->photoSkill);
                }
                catch(const std::exception& e)
                {
                    logger->error("Could not get parameters NodeIds for Camera endpoint: " 
                        + s.first->photoSkill->getParentComponent()->endpointUrl);
                    skillCalls.erase(s.first);
                    break;
                }


                // Get ImagePNG NodeId and read the image from it.
                logger->trace("Reading ImagePNG from endpoint URL: " + s.first->photoSkill->getParentComponent()->endpointUrl);

                if(nodeIds.find("ImagePNG") == nodeIds.end())
                {
                    logger->error("Could not find ImagePNG variable on Camera endpoint: " + s.first->photoSkill->getParentComponent()->endpointUrl);
                    skillCalls.erase(s.first);
                    break;
                }

                LockedClient lc = s.first->photoSkill->getParentComponent()->getLockedClient();

                try
                {
                    readImagePNG(lc.get(), nodeIds["ImagePNG"], &s.first->photo);
                }
                catch(const std::exception& e)
                {
                    logger->error("Could not read ImagePNG variable on Camera endpoint: " + s.first->photoSkill->getParentComponent()->endpointUrl
                                    + "Returned: " + std::string(e.what()));
                    skillCalls.erase(s.first);
                    break;
                }
                
                // Get CameraPose NodeId and read pose from it.
                try
                {
                    if(nodeIds.find("CameraInfo") != nodeIds.end())
                    {
                        logger->trace("Reading CameraInfo from endpoint URL: " + s.first->photoSkill->getParentComponent()->endpointUrl);
                        UA_CameraInfoDataType camInfo;
                        UA_StatusCode ret = readCameraInfo(lc.get(), nodeIds["CameraInfo"], &camInfo);
                        if(ret == UA_STATUSCODE_GOOD)
                            UA_CameraInfoDataType_copy(&camInfo, &s.first->camInfo);
                        else
                            logger->error("Could not read CameraInfo parameter on Camera endpoint: " + s.first->photoSkill->getParentComponent()->endpointUrl
                                    + "Returned: " + std::string(UA_StatusCode_name(ret)));
                    }
                    else
                    {
                        logger->error("Could not find CameraInfo parameter on Camera endpoint: " + s.first->photoSkill->getParentComponent()->endpointUrl);
                    }

                    if(nodeIds.find("CameraPose") != nodeIds.end())
                    {
                        logger->trace("Reading CameraPose from endpoint URL: " + s.first->photoSkill->getParentComponent()->endpointUrl);
                        readCameraPose(lc.get(), nodeIds["CameraPose"], &s.first->pose);
                    }
                    else
                    {
                        logger->error("Could not find CameraPose parameter on Camera endpoint: " + s.first->photoSkill->getParentComponent()->endpointUrl);
                    }
                }
                catch(const std::exception& e)
                {
                    logger->error("Could not read parameters on Camera endpoint: " + s.first->photoSkill->getParentComponent()->endpointUrl
                                    + "Returned: " + std::string(e.what()));
                    skillCalls.erase(s.first);
                    break;
                }

                cameraData.push_back(s.first);
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
