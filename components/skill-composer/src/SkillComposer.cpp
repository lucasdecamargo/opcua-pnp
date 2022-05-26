#include <SkillComposer.h>

#include <open62541/client.h>
#include <open62541/client_highlevel.h>
#include <helper.hpp>

#include <namespace_di_generated.h>
#include <namespace_device_model_generated.h>
#include <namespace_pnp_types_generated.h>
#include <namespace_skill_composer_generated.h>

#include <device_model_nodeids.h>
#include <di_nodeids.h>
#include <skill_composer_nodeids.h>

#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

SkillComposer::SkillComposer(
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const libconfig::Setting& skillComposerSettings,
        const std::string& clientCertPath,
        const std::string& clientKeyPath,
        const std::string& clientAppUri,
        const std::string& clientName
    ):
    logger(std::move(_loggerApp)),
    loggerOpcua(std::move(_loggerOpcua)),
    server(server),
    skillComposerSettings(skillComposerSettings),
    clientCertPath(clientCertPath),
    clientKeyPath(clientKeyPath),
    clientAppUri(clientAppUri),
    clientName(clientName),
    skillDetector(new SkillDetector(logger, loggerOpcua, clientCertPath, clientKeyPath, clientAppUri, clientName))
{
    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize Skill Composer nodeset");
    }

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw pnp::opcua::StatusCodeException(retval);
}

SkillComposer::~SkillComposer()
{
    // ...
}

UA_StatusCode SkillComposer::initSkills()
{
    logger->info("Initializing skills");
    UA_NodeId markerFindingSkillId;
    {
        LockedServer ls = server->getLocked();

        markerFindingSkillId = UA_NODEID_NUMERIC
        (
            pnp::opcua::UA_Server_getNamespaceIdByName(ls.get(), NAMESPACE_URI_SKILLCOMPOSER),
            UA_SKILL_COMPOSERID_SKILLCOMPOSERDEVICE_SKILLS_MARKERFINDINGSKILL
        );
    }

    logger->trace("Instantiating Marker Finding Skill Implementation");
    markerFindingSkillImpl = new MarkerFindingSkillImpl(server, logger, 
                                    loggerOpcua, skillDetector, skillComposerSettings);

    logger->trace("Instantiating Marker Finding Skill");
    markerFindingSkill = std::make_unique<pnp::opcua::skill::skill_composer::MarkerFindingSkill>
        (server, logger, markerFindingSkillId, "MarkerFindingSkill");
    
    logger->trace("Setting implementation");
    markerFindingSkill->setImpl(markerFindingSkillImpl, [this](){ delete markerFindingSkillImpl; });

    logger->trace("Executing transition to READY");
    markerFindingSkill->transition(pnp::opcua::ProgramStateNumber::READY);

    return UA_STATUSCODE_GOOD;
}

bool SkillComposer::createNodesFromNodeset()
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

    logger->trace("Generating SkillComposer namespace");
    if(namespace_skill_composer_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the SkillComposer namespace failed. Please check previous error output.");
        return false;
    }

    return true;
}

void SkillComposer::onServerAnnounce(
        const UA_ServerOnNetwork* serverOnNetwork,
        UA_Boolean isServerAnnounce
    ) 
{
    logger->trace("onServerAnnounce");
    return skillDetector->onServerAnnounce(serverOnNetwork, isServerAnnounce);
}
