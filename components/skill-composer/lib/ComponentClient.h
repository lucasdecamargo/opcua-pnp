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
    explicit ComponentClient(std::shared_ptr<spdlog::logger> logger,
                             const std::shared_ptr<RegisteredSkill> skill);
    
    virtual ~ComponentClient();

    bool connect();
    void disconnect();

    virtual UA_StatusCode getNodeIds() = 0;

protected:
    std::shared_ptr<spdlog::logger> logger
    const std::shared_ptr<RegisteredSkill> skill;
    static const UA_DataTypeArray customDataTypes;
};

class CameraClient : public ComponentClient
{
public:
    explicit CameraClient(std::shared_ptr<spdlog::logger> logger,
                             const std::shared_ptr<RegisteredSkill> skill);
    
    virtual UA_StatusCode getNodeIds() override;

    UA_StatusCode readImageNode(UA_ImagePNG* data);
    UA_StatusCode readCameraInfoNode(UA_CameraInfoDataType* data);
    UA_StatusCode readCameraPoseNode(UA_PoseDataType* data);
};

#endif