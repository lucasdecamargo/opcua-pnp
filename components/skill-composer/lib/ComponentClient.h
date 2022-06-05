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

    virtual getNodeIds() = 0;

protected:
    const std::shared_ptr<RegisteredSkill> skill;
};

class CameraClient : public ComponentClient
{
public:
    explicit CameraClient(std::shared_ptr<spdlog::logger> logger,
                             const std::shared_ptr<RegisteredSkill> skill);
    
    virtual ~ComponentClient();

    virtual getNodeIds() override;

    UA_StatusCode readCameraInfoNode(UA_CameraInfoDataType* data);
    UA_StatusCode readCameraPoseNode(UA_PoseDataType* data);
};

#endif