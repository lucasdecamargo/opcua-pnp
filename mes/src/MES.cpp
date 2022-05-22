#include <MES.h>

#include <string>
#include <utility>

#include <helper.hpp>
#include <open62541/client_highlevel.h>
#include <open62541/client_config_default.h>
#include <open62541/server.h>
#include <logging_opcua.h>

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
        pnpSetting(pnpSetting)
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
    return true;
}

UA_StatusCode MES::initSkills()
{
    return UA_STATUSCODE_GOOD;
}

void MES::onServerRegister(const UA_RegisteredServer* registeredServer)
{
    /* ... */
    logger->info("[MES] onServerRegister");
}

void MES::onServerAnnounce(
        const UA_ServerOnNetwork* serverOnNetwork,
        UA_Boolean isServerAnnounce
)
{
    /* ... */
    logger->info("Server announced! Name: "s + std::string((char*)serverOnNetwork->serverName.data)
        + " DiscoveryUrl: "s + std::string((char*)serverOnNetwork->discoveryUrl.data)
    );
}
