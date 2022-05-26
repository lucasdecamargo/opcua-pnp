#ifndef PNP_MARKERFINDINGSKILLIMPL_H
#define PNP_MARKERFINDINGSKILLIMPL_H

#include <OpcUaServer.h>
#include <skills/skill_composer/MarkerFindingSkill.hpp>

#include <client/SkillDetector.h>
#include <client/RegisteredComponent.h>

#include <types_pnp_types_generated.h>

class MarkerFindingSkillImpl
    : virtual public pnp::opcua::skill::skill_composer::MarkerFindingSkillImpl
{
private:
    const std::shared_ptr<pnp::opcua::OpcUaServer> server;
    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcUa;
    const std::shared_ptr<SkillDetector>& skillDetector;
    const libconfig::Setting& skillComposerSettings;

public:
    explicit MarkerFindingSkillImpl(
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const std::shared_ptr<spdlog::logger>& logger,
        const std::shared_ptr<spdlog::logger>& loggerOpcUa,
        const std::shared_ptr<SkillDetector>& skillDetector,
        const libconfig::Setting& skillComposerSettings
    );

    virtual ~MarkerFindingSkillImpl() {}

    virtual bool start(std::vector<UA_MarkerDataType>& foundMarkers) override;

    bool halt() override;
    bool resume() override;
    bool suspend() override;
    bool reset() override;

protected:
    typedef struct
    {
        std::shared_ptr<RegisteredComponent> camera;
        UA_PoseDataType pose;
        UA_ImagePNG photo;
        std::vector<UA_MarkerDataType> markers;
    } CameraData;
    
    std::vector<std::shared_ptr<RegisteredSkill>> 
    findRegisteredSKillByName(const std::string name);

    std::vector<CameraData>
    getCameraData(const std::vector<std::shared_ptr<RegisteredSkill>>& photoSkills);

    
};

#endif
