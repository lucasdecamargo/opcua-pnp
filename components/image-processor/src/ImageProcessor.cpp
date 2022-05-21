#include <ImageProcessor.h>

#include <open62541/client.h>
#include <open62541/client_highlevel.h>
#include <helper.hpp>

#include <namespace_di_generated.h>
#include <namespace_device_model_generated.h>
#include <namespace_pnp_types_generated.h>
#include <namespace_image_processor_generated.h>

#include <device_model_nodeids.h>
#include <di_nodeids.h>
#include <image_processor_nodeids.h>

#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

ImageProcessor::ImageProcessor(
    std::shared_ptr<spdlog::logger> _loggerApp,
    std::shared_ptr<spdlog::logger> _loggerOpcua,
    const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
    const libconfig::Setting& imageProcessorSettings,
    const std::string& markersFilePath
) :
    logger(_loggerApp),
    loggerOpcua(_loggerOpcua),
    server(server),
    imageProcessorSettings(imageProcessorSettings),
    markersFilePath(markersFilePath)
{
    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize Image Processor nodeset");
    }

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw pnp::opcua::StatusCodeException(retval);
}

ImageProcessor::~ImageProcessor()
{
    // ...
}

UA_StatusCode ImageProcessor::initSkills()
{
    logger->info("Initializing skills");
    UA_NodeId markerDetectionSkillId;
    {
        LockedServer ls = server->getLocked();

        markerDetectionSkillId = UA_NODEID_NUMERIC
        (
            pnp::opcua::UA_Server_getNamespaceIdByName(ls.get(), NAMESPACE_URI_IMAGEPROCESSOR),
            UA_IMAGE_PROCESSORID_IMAGEPROCESSORDEVICE_SKILLS_MARKERDETECTIONSKILL
        );
    }

    logger->trace("Instantiating Marker Detection Skill Implementation");
    markerDetectionSkillImpl = new MarkerDetectionSkillImpl(server, logger, imageProcessorSettings, markersFilePath);

    logger->trace("Instantiating Marker Detection Skill");
    markerDetectionSkill = std::make_unique<pnp::opcua::skill::image_processor::MarkerDetectionSkill>
        (server, logger, markerDetectionSkillId, "MarkerDetectionSkill");
    
    logger->trace("Setting implementation");
    markerDetectionSkill->setImpl(markerDetectionSkillImpl, [this](){ delete markerDetectionSkillImpl; });

    logger->trace("Executing transition to READY");
    markerDetectionSkill->transition(pnp::opcua::ProgramStateNumber::READY);

    return UA_STATUSCODE_GOOD;
}

bool ImageProcessor::createNodesFromNodeset()
{
    logger->info("Creating nodes from nodeset");
    LockedServer ls = server->getLocked();

    logger->trace("Generating DI namespace");
    if(namespace_di_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }

    logger->trace("Generating DeviceModel namespace");
    if(namespace_device_model_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the DeviceModel namespace failed. Please check previous error output.");
        return false;
    }

    logger->trace("Generating PnPTypes namespace");
    if(namespace_pnp_types_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the PnPTypes namespace failed. Please check previous error output.");
        return false;
    }

    logger->trace("Generating ImageProcessor namespace");
    if(namespace_image_processor_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the ImageProcessor namespace failed. Please check previous error output.");
        return false;
    }

    return true;
}
