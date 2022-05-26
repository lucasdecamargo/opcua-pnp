#ifndef PNP_MES_H
#define PNP_MES_H

#include <OpcUaServer.h>
#include <libconfig.h++>
#include <spdlog/spdlog.h>

#include <client/SkillDetector.h>

class MES
{
public:
    explicit MES(
            std::shared_ptr<spdlog::logger> _loggerApp,
            std::shared_ptr<spdlog::logger> _loggerOpcua,
            const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
            const std::string& clientCertPath,
            const std::string& clientKeyPath,
            const libconfig::Setting& pnpSetting
    );

    virtual ~MES();

    MES(const MES&) = delete;

    void onServerRegister(const UA_RegisteredServer* registeredServer);
    void onServerAnnounce(
            const UA_ServerOnNetwork* serverOnNetwork,
            UA_Boolean isServerAnnounce
    );

protected:
    virtual bool createNodesFromNodeset();

    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    const std::shared_ptr<pnp::opcua::OpcUaServer> server;

    virtual UA_StatusCode initSkills();

private:
    bool running = false;
    const libconfig::Setting& pnpSetting;
    std::unique_ptr<SkillDetector> skillDetector;
};

#endif