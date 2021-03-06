#include <ComponentClient.h>

#include <open62541/client_highlevel.h>

const UA_DataTypeArray ComponentClient::customDataTypes = {NULL, UA_TYPES_PNP_TYPES_COUNT, UA_TYPES_PNP_TYPES};

ComponentClient::ComponentClient(std::shared_ptr<spdlog::logger>& logger,
                std::shared_ptr<spdlog::logger>& loggerOpcua,
                const std::shared_ptr<RegisteredSkill> skill) :
    logger(logger), loggerOpcua(loggerOpcua), skill(skill)
{

}

ComponentClient::~ComponentClient()
{
    disconnect();
}


bool ComponentClient::connect()
{
    bool ret = skill->getParentComponent()->connectClient();
    
    if(ret)
    {
        LockedClient lc = skill->getParentComponent()->getLockedClient();
        UA_Client_getConfig(lc.get())->customDataTypes = &customDataTypes;
    } 

    return ret;
}

void ComponentClient::disconnect()
{
    return skill->getParentComponent()->disconnectClient();
}

bool ComponentClient::ensureConnected()
{
    return skill->getParentComponent()->ensureConnected();
}

std::future<bool> ComponentClient::execute(
    const std::vector<std::shared_ptr<SkillParameter>>& parameters, 
    const bool autoDisconnect)
{
    return skill->execute(logger, loggerOpcua, parameters, autoDisconnect, &customDataTypes);
}


CameraClient::CameraClient(std::shared_ptr<spdlog::logger>& logger,
                std::shared_ptr<spdlog::logger>& loggerOpcua,
                const std::shared_ptr<RegisteredSkill> skill) :
    ComponentClient(logger,loggerOpcua, skill),
    imageNodeId(UA_NODEID_NULL),
    cameraInfoNodeId(UA_NODEID_NULL),
    cameraPoseNodeId(UA_NODEID_NULL)
{

}

std::future<bool> CameraClient::execute(const bool autoDisconnect)
{
    std::vector<std::shared_ptr<SkillParameter>> params;
    return this->ComponentClient::execute(params, autoDisconnect);
}

UA_NodeId CameraClient::getParemeterSetNodeId()
{
    UA_NodeId parameterSetNodeId;
    UA_UInt16 nsIdxDi;
    
    LockedClient lc = skill->getParentComponent()->getLockedClient();
    UA_String nsUri = UA_String_fromChars(NAMESPACE_URI_DI);
    UA_StatusCode retval = UA_Client_NamespaceGetIndex(lc.get(), &nsUri, &nsIdxDi);
    UA_String_clear(&nsUri);
    if (retval != UA_STATUSCODE_GOOD) {
        throw std::runtime_error("Failed get namespace index for DI Namespace." + std::string(UA_StatusCode_name(retval)));
    }

    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        lc.get(), logger, skill->getSkillControllerNodeId(),
        UA_QUALIFIEDNAME(nsIdxDi,
        const_cast<char *>("ParameterSet")),
        &parameterSetNodeId))
        throw std::runtime_error("Could not find Cameras ParameterSet NodeId");

    return parameterSetNodeId;
}

UA_StatusCode CameraClient::getNodeIds()
{
    UA_NodeId parameterSetNodeId = getParemeterSetNodeId();
    UA_NodeId skillControllerNodeId = skill->getSkillControllerNodeId();

    LockedClient lc = skill->getParentComponent()->getLockedClient();
    UA_UInt16 nsIdxCamera;
    UA_String nsCamera = UA_String_fromChars("https://pnp.org/UA/Camera/");
    UA_StatusCode retval = UA_Client_NamespaceGetIndex(lc.get(), &nsCamera, &nsIdxCamera);
    UA_String_clear(&nsCamera);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Failed get namespace index for Camera Namespace." + std::string(UA_StatusCode_name(retval)));
        return retval;
    }

    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        lc.get(), logger, skillControllerNodeId,
        UA_QUALIFIEDNAME(nsIdxCamera,
        const_cast<char *>("ImagePNG")),
        &imageNodeId))
        logger->error("Could not find ImagePNG NodeId");
    
    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        lc.get(), logger, parameterSetNodeId,
        UA_QUALIFIEDNAME(nsIdxCamera,
        const_cast<char *>("CameraInfo")),
        &cameraInfoNodeId))
        logger->error("Could not find CameraInfo NodeId");
    
    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        lc.get(), logger, parameterSetNodeId,
        UA_QUALIFIEDNAME(nsIdxCamera,
        const_cast<char *>("CameraPose")),
        &cameraPoseNodeId))
        logger->error("Could not find CameraPose NodeId");
    
    return UA_STATUSCODE_GOOD;
}

UA_StatusCode CameraClient::readImageNode(UA_ImagePNG* data)
{
    if(UA_NodeId_isNull(&imageNodeId))
    {
        logger->error("imageNodeId is null");
        return UA_STATUSCODE_BADNODEIDUNKNOWN;
    }

    LockedClient lc = skill->getParentComponent()->getLockedClient();

    UA_Variant v;
    UA_StatusCode ret = pnp::opcua::UA_Client_readVariable(lc.get(), imageNodeId, &v);
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
    
    ret = UA_ImagePNG_copy((UA_ImagePNG*)v.data, data);

    UA_Variant_clear(&v);

    return ret;    
}

UA_StatusCode CameraClient::readCameraInfoNode(UA_CameraInfoDataType* data)
{
    if(UA_NodeId_isNull(&cameraInfoNodeId))
    {
        logger->error("cameraInfoNodeId is null");
        return UA_STATUSCODE_BADNODEIDUNKNOWN;
    }

    LockedClient lc = skill->getParentComponent()->getLockedClient();

    UA_Variant v;
    UA_StatusCode ret = pnp::opcua::UA_Client_readVariable(lc.get(), cameraInfoNodeId, &v);
    if (ret != UA_STATUSCODE_GOOD)
    {
        logger->error("Cannot read camera info node: " + std::string(UA_StatusCode_name(ret)));
        return ret;
    }

    if(v.type == &UA_TYPES[UA_TYPES_EXTENSIONOBJECT])
    {
        UA_Variant_clear(&v);
        logger->error("CameraInfoNode is of unknown type");
        return UA_STATUSCODE_BADTYPEMISMATCH;
    }
    // if(v.type != &UA_TYPES[UA_TYPES_PNP_TYPES_CAMERAINFODATATYPE])
    // {
    //     const char* typeName = v.type->typeName;
    //     UA_Variant_clear(&v);
    //     logger->error("Cannot read camera info node with type " + std::string(typeName));
    //     return UA_STATUSCODE_BADTYPEMISMATCH;
    // }

    ret = UA_CameraInfoDataType_copy((UA_CameraInfoDataType*)v.data, data);

    UA_Variant_clear(&v);
    return ret;
}

UA_StatusCode CameraClient::readCameraPoseNode(UA_PoseDataType* data)
{
    if(UA_NodeId_isNull(&cameraPoseNodeId))
    {
        logger->error("cameraPoseNodeId is null");
        return UA_STATUSCODE_BADNODEIDUNKNOWN;
    }

    LockedClient lc = skill->getParentComponent()->getLockedClient();

    UA_Variant v;
    UA_StatusCode ret = pnp::opcua::UA_Client_readVariable(lc.get(), cameraPoseNodeId, &v);
    if (ret != UA_STATUSCODE_GOOD)
    {
        logger->error("Cannot read camera pose node: " + std::string(UA_StatusCode_name(ret)));
        return ret;
    }

    if(v.type == &UA_TYPES[UA_TYPES_EXTENSIONOBJECT])
    {
        UA_Variant_clear(&v);
        logger->error("CameraPoseNode is of unknown type");
        return UA_STATUSCODE_BADTYPEMISMATCH;
    }
    // if(v.type != &UA_TYPES[UA_TYPES_PNP_TYPES_POSEDATATYPE])
    // {
    //     const char* typeName = v.type->typeName;
    //     UA_Variant_clear(&v);
    //     logger->error("Cannot read camera pose node with type " + std::string(typeName));
    //     return UA_STATUSCODE_BADTYPEMISMATCH;
    // }

    ret = UA_PoseDataType_copy((UA_PoseDataType*)v.data, data);

    UA_Variant_clear(&v);
    return ret;
}



ImageProcessorClient::ImageProcessorClient(std::shared_ptr<spdlog::logger>& logger,
                std::shared_ptr<spdlog::logger>& loggerOpcua,
                const std::shared_ptr<RegisteredSkill> skill) :
    ComponentClient(logger,loggerOpcua, skill),
    detectedMarkersNodeId(UA_NODEID_NULL),
    outputImageNodeId(UA_NODEID_NULL)
{

}


UA_StatusCode ImageProcessorClient::getNodeIds()
{
    UA_NodeId parameterSetNodeId = skill->getParameterSetNodeId();

    LockedClient lc = skill->getParentComponent()->getLockedClient();
    UA_UInt16 nsIdxImageProcessor;
    UA_String nsImageProcessor = UA_String_fromChars("https://pnp.org/UA/ImageProcessor/");
    UA_StatusCode retval = UA_Client_NamespaceGetIndex(lc.get(), &nsImageProcessor, &nsIdxImageProcessor);
    UA_String_clear(&nsImageProcessor);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Failed get namespace index for ImageProcessor Namespace." + std::string(UA_StatusCode_name(retval)));
        return retval;
    }

    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        lc.get(), logger, parameterSetNodeId,
        UA_QUALIFIEDNAME(nsIdxImageProcessor,
        const_cast<char *>("DetectedMarkersArray")),
        &detectedMarkersNodeId))
        logger->error("Could not find DetectedMarkersArray NodeId");
    
    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        lc.get(), logger, parameterSetNodeId,
        UA_QUALIFIEDNAME(nsIdxImageProcessor,
        const_cast<char *>("OutputImage")),
        &outputImageNodeId))
        logger->error("Could not find OutputImage NodeId");
    
    return UA_STATUSCODE_GOOD;
}

std::future<bool> ImageProcessorClient::execute(const UA_ByteString* inputImage,
    const UA_CameraInfoDataType* cameraInfo,
    const bool autoDisconnect)
{
    std::vector <std::shared_ptr<SkillParameter>> parameters = std::vector < std::shared_ptr < SkillParameter >> ();
    parameters.reserve(2);

    {
        UA_Variant v;
        UA_Variant_init(&v);
        UA_Variant_setScalarCopy(&v, inputImage, &UA_TYPES[UA_TYPES_IMAGEPNG]);

        std::shared_ptr <SkillParameter> param = std::make_shared<SkillParameter>(
                        "InputImage",
                        "",
                        "");

        param->setValue(v);
        UA_Variant_clear(&v);
        parameters.emplace_back(param);
    }

    {
        UA_Variant v;
        UA_Variant_init(&v);
        UA_Variant_setScalarCopy(&v, cameraInfo, &UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_CAMERAINFODATATYPE]);

        std::shared_ptr <SkillParameter> param = std::make_shared<SkillParameter>(
                        "CameraInfo",
                        "",
                        "");

        param->setValue(v);
        UA_Variant_clear(&v);
        parameters.emplace_back(param);
    }

    return this->ComponentClient::execute(parameters, autoDisconnect);
}

UA_StatusCode ImageProcessorClient::readDetectedMarkersArrayNode(std::vector<UA_MarkerDataType>& data)
{
    if(UA_NodeId_isNull(&detectedMarkersNodeId))
    {
        logger->error("detectedMarkersNodeId is null");
        return UA_STATUSCODE_BADNODEIDUNKNOWN;
    }

    LockedClient lc = skill->getParentComponent()->getLockedClient();

    UA_Variant v;
    UA_StatusCode ret = pnp::opcua::UA_Client_readVariable(lc.get(), detectedMarkersNodeId, &v);
    if (ret != UA_STATUSCODE_GOOD)
    {
        logger->error("Cannot read detected markers array node: " + std::string(UA_StatusCode_name(ret)));
        return ret;
    }

    if(v.type != &UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_MARKERLISTDATATYPE])
    {
        logger->error("DetectedMarkersArray is expected to be of type MarkerListDataType and not of type " 
            + std::string(v.type->typeName));
        UA_Variant_clear(&v);
        return UA_STATUSCODE_BADTYPEMISMATCH;
    }
    
    UA_MarkerListDataType* m_list = reinterpret_cast<UA_MarkerListDataType*>(v.data);
    UA_MarkerDataType* m = reinterpret_cast<UA_MarkerDataType*>(m_list->markers);

    for(size_t i = 0; i < m_list->markersSize; i++)
    {
        data.push_back(m[i]);
        UA_String_copy(&m[i].dictionary, &data.back().dictionary); // WARNING! Has to be cleared when destructing array
    }

    UA_Variant_clear(&v);
    return ret;
}

UA_StatusCode ImageProcessorClient::readOutputImageNode(UA_ImagePNG* data)
{
    if(UA_NodeId_isNull(&outputImageNodeId))
    {
        logger->error("outputImageNodeId is null");
        return UA_STATUSCODE_BADNODEIDUNKNOWN;
    }

    LockedClient lc = skill->getParentComponent()->getLockedClient();

    UA_Variant v;
    UA_StatusCode ret = pnp::opcua::UA_Client_readVariable(lc.get(), outputImageNodeId, &v);
    if (ret != UA_STATUSCODE_GOOD)
    {
        logger->error("Cannot read output image node: " + std::string(UA_StatusCode_name(ret)));
        return ret;
    }
    if(v.type != &UA_TYPES[UA_TYPES_IMAGEPNG] && v.type != &UA_TYPES[UA_TYPES_BYTESTRING])
    {
        const char* typeName = v.type->typeName;
        UA_Variant_clear(&v);
        logger->error("Cannot read output image node. Is not of type ImagePNG but of type "
            + std::string(typeName));
        return ret;
    }

    logger->info("Read Image of TypeName: " + std::string(v.type->typeName));
    
    ret = UA_ImagePNG_copy((UA_ImagePNG*)v.data, data);

    UA_Variant_clear(&v);

    return ret; 
}

