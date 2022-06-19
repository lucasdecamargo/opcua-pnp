#ifndef PNP_MARKERFINDINGSKILLIMPL_H
#define PNP_MARKERFINDINGSKILLIMPL_H

#include <OpcUaServer.h>
#include <skills/skill_composer/MarkerFindingSkill.hpp>
#include <ComponentClient.h>

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
    struct CameraData
    {
        std::shared_ptr<CameraClient> cameraClient;
        UA_PoseDataType pose;
        UA_CameraInfoDataType camInfo;
        UA_ImagePNG photo;
        std::vector<UA_MarkerDataType> markers;

        CameraData()
        {
            UA_CameraInfoDataType_init(&camInfo);
            camInfo.cameraMatrixSize = 0;
            camInfo.distortionCoefficientsSize = 0;
            camInfo.cameraMatrix = NULL;
            camInfo.distortionCoefficients = NULL;

            UA_PoseDataType_init(&pose);
            pose.position.x = NAN;
            pose.position.y = NAN;
            pose.position.z = NAN;
            pose.rotation.r = NAN;
            pose.rotation.p = NAN;
            pose.rotation.y = NAN;

            UA_ImagePNG_init(&photo);
            photo.length = 0;
            photo.data = NULL;
        }

        ~CameraData()
        {
            UA_CameraInfoDataType_clear(&camInfo);
            UA_ImagePNG_clear(&photo);

            for(auto &m : markers)
                UA_String_clear(&m.dictionary);
        }
    };

    std::vector<std::shared_ptr<CameraData>>
    getCameraData(const std::vector<std::shared_ptr<RegisteredSkill>>& photoSkills);

    void detectMarkers(std::shared_ptr<RegisteredSkill> markerDetectionSkill, std::vector<std::shared_ptr<CameraData>> cameraData);

    UA_NodeId getCameraParameterSetNodeId(std::shared_ptr<RegisteredSkill>& photoSkill);
    
    std::map<std::string, UA_NodeId> 
    getCameraParametersNodeIds(std::shared_ptr<RegisteredSkill>& photoSkill);


    UA_StatusCode readImagePNG(UA_Client* client, UA_NodeId& imageNodeId, UA_ImagePNG *image); 
    UA_StatusCode readCameraInfo(UA_Client* client, UA_NodeId& cameraInfoNodeId, 
                                 UA_CameraInfoDataType *data); 
    UA_StatusCode readCameraPose(UA_Client* client, UA_NodeId& cameraPoseNodeId, 
                                 UA_PoseDataType *data);
};

#endif
