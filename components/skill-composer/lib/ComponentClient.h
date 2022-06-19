#ifndef PNP_SKILLCOMPOSER_COMPONENTCLIENT_H
#define PNP_SKILLCOMPOSER_COMPONENTCLIENT_H

#include <map>
#include <memory>

#include <client/RegisteredSkill.h>

#include <helper.hpp>

#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

class ComponentClient
{
public:
    explicit ComponentClient(std::shared_ptr<spdlog::logger>& logger,
                            std::shared_ptr<spdlog::logger>& loggerOpcua,
                            const std::shared_ptr<RegisteredSkill> skill);
    
    virtual ~ComponentClient();

    bool connect();
    void disconnect();
    bool ensureConnected();

    std::future<bool> execute(const std::vector<std::shared_ptr<SkillParameter>>& parameters, const bool autoDisconnect = false);
    std::shared_ptr<RegisteredComponent> getParentComponent() {return skill->getParentComponent();}

    virtual UA_StatusCode getNodeIds() = 0;

protected:
    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    std::shared_ptr<RegisteredSkill> skill;
    static const UA_DataTypeArray customDataTypes;
};

class CameraClient : public ComponentClient
{
public:
    explicit CameraClient(std::shared_ptr<spdlog::logger>& logger,
                            std::shared_ptr<spdlog::logger>& loggerOpcua,
                            const std::shared_ptr<RegisteredSkill> skill);
    
    virtual UA_StatusCode getNodeIds() override;

    std::future<bool> execute(const bool autoDisconnect = false);

    UA_StatusCode readImageNode(UA_ImagePNG* data);
    UA_StatusCode readCameraInfoNode(UA_CameraInfoDataType* data);
    UA_StatusCode readCameraPoseNode(UA_PoseDataType* data);

protected:
    UA_NodeId getParemeterSetNodeId();

    UA_NodeId imageNodeId;
    UA_NodeId cameraInfoNodeId;
    UA_NodeId cameraPoseNodeId;
};


class ImageProcessorClient : public ComponentClient
{
public:
    explicit ImageProcessorClient(std::shared_ptr<spdlog::logger>& logger,
                            std::shared_ptr<spdlog::logger>& loggerOpcua,
                            const std::shared_ptr<RegisteredSkill> skill);

    virtual UA_StatusCode getNodeIds() override;

    std::future<bool> execute(const UA_ByteString* inputImage,
                              const UA_CameraInfoDataType* cameraInfo,
                              const bool autoDisconnect = false);

    UA_StatusCode readDetectedMarkersArrayNode(std::vector<UA_MarkerDataType>& data);
    UA_StatusCode readOutputImageNode(UA_ImagePNG* data);

protected:
    UA_NodeId detectedMarkersNodeId;
    UA_NodeId outputImageNodeId;
};

#endif