#ifndef PNP_CAMERA_H
#define PNP_CAMERA_H

#include <OpcUaServer.h>
#include <libconfig.h++>

#include <PhotoSkillImpl.h>
#include <CameraDevice.h>

class Camera
{
public:
    explicit Camera(
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const libconfig::Setting& cameraSettings,
        std::shared_ptr<CameraDevice>& cameraDevice
    );

    virtual ~Camera();

    Camera(const Camera&) = delete;

    const libconfig::Setting& cameraSettings;
    std::shared_ptr<CameraDevice> device;

private:
    UA_StatusCode initSkills();
    bool createNodesFromNodeset();
    UA_StatusCode setParameters();

    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    std::shared_ptr<pnp::opcua::OpcUaServer> server;

    PhotoSkillImpl *photoSkillImpl{};
    std::unique_ptr<pnp::opcua::skill::camera::PhotoSkill> photoSkill;

};

#endif