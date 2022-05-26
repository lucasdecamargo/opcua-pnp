#ifndef PNP_SKILLCOMPOSER_H
#define PNP_SKILLCOMPOSER_H

#include <OpcUaServer.h>
#include <libconfig.h++>

#include <MarkerFindingSkillImpl.h>

#include <client/SkillDetector.h>

class SkillComposer
{
public:
    explicit SkillComposer(
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const libconfig::Setting& skillComposerSettings,
        const std::string& clientCertPath,
        const std::string& clientKeyPath,
        const std::string& clientAppUri,
        const std::string& clientName
    );

    virtual ~SkillComposer();

    SkillComposer(const SkillComposer&) = delete;

    void onServerAnnounce(
            const UA_ServerOnNetwork* serverOnNetwork,
            UA_Boolean isServerAnnounce
    );

    const libconfig::Setting& skillComposerSettings;

private:
    UA_StatusCode initSkills();
    bool createNodesFromNodeset();

    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    std::shared_ptr<pnp::opcua::OpcUaServer> server;
    std::shared_ptr<SkillDetector> skillDetector;

    const std::string clientCertPath;
    const std::string clientKeyPath;
    const std::string clientAppUri;
    const std::string clientName;

    MarkerFindingSkillImpl *markerFindingSkillImpl{};
    std::unique_ptr<pnp::opcua::skill::skill_composer::MarkerFindingSkill> markerFindingSkill;
};

#endif