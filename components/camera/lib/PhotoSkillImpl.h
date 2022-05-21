#ifndef PNP_CAMERA_PHOTOSKILLIMPL_H
#define PNP_CAMERA_PHOTOSKILLIMPL_H

#include <OpcUaServer.h>
#include <skills/camera/PhotoSkill.hpp>
#include <CameraDevice.h>

class PhotoSkillImpl 
    : virtual public pnp::opcua::skill::camera::PhotoSkillImpl
{
private:
    const std::shared_ptr<pnp::opcua::OpcUaServer> server;
    const std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<CameraDevice> device;
    UA_NodeId outImageNodeId;

public:
    explicit PhotoSkillImpl(
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const std::shared_ptr<spdlog::logger>& logger,
        const std::shared_ptr<CameraDevice>& cameraDevice,
        UA_NodeId& outImageNodeId
    );

    virtual ~PhotoSkillImpl() { }

    bool start() override;
    bool halt() override;
    bool resume() override;
    bool suspend() override;
    bool reset() override;
};

#endif