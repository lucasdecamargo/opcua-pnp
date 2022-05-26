#include <MES.h>

#include <string>
#include <utility>

#include <helper.hpp>
#include <open62541/client_highlevel.h>
#include <open62541/client_config_default.h>
#include <open62541/server.h>
#include <logging_opcua.h>

#include <namespace_di_generated.h>
#include <namespace_device_model_generated.h>
#include <namespace_pnp_types_generated.h>

using namespace std::string_literals;

MES::MES(
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const std::string& clientCertPath,
        const std::string& clientKeyPath,
        const libconfig::Setting& pnpSetting
) :
        logger(std::move(_loggerApp)),
        loggerOpcua(std::move(_loggerOpcua)),
        server(server),
        pnpSetting(pnpSetting),
        skillDetector(new SkillDetector(logger, loggerOpcua, clientCertPath, clientKeyPath,
                        "pnp.mes.client", "MES Client"))
{

    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize Semantic MES nodeset");
    }

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw pnp::opcua::StatusCodeException(retval);

}

MES::~MES()
{

}

bool MES::createNodesFromNodeset()
{
    LockedServer ls = server->getLocked();

    if(namespace_di_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }

    if(namespace_device_model_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the DeviceModel namespace failed. Please check previous error output.");
        return false;
    }

    if(namespace_pnp_types_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the PnPTypes namespace failed. Please check previous error output.");
        return false;
    }
    return true;
}

UA_StatusCode MES::initSkills()
{
    return UA_STATUSCODE_GOOD;
}

void MES::onServerRegister(const UA_RegisteredServer* registeredServer)
{
    logger->trace("onServerRegister");
    return skillDetector->onServerRegister(registeredServer);
}

void MES::onServerAnnounce(
        const UA_ServerOnNetwork* serverOnNetwork,
        UA_Boolean isServerAnnounce
)
{
    logger->trace("onServerAnnounce");
    return skillDetector->onServerAnnounce(serverOnNetwork, isServerAnnounce);
}
