#ifndef PNP_MARKERDETECTIONSKILLIMPL_H
#define PNP_MARKERDETECTIONSKILLIMPL_H

#include <OpcUaServer.h>
#include <skills/image_processor/MarkerDetectionSkill.hpp>

class MarkerDetectionSkillImpl
    : virtual public pnp::opcua::skill::image_processor::MarkerDetectionSkillImpl
{
private:
    const std::shared_ptr<pnp::opcua::OpcUaServer> server;
    const std::shared_ptr<spdlog::logger> logger;
    const std::string markersFilePath;
    const libconfig::Setting& imageProcessorSettings;

public:
    explicit MarkerDetectionSkillImpl(
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const std::shared_ptr<spdlog::logger>& logger,
        const libconfig::Setting& imageProcessorSettings,
        const std::string& markersFilePath
    );

    virtual ~MarkerDetectionSkillImpl() {}

    virtual bool start(const UA_CameraInfoDataType& cameraInfo,
                       const UA_ByteString& inputImage,
                       std::vector<UA_MarkerDataType>& detectedMarkers,
                       UA_ImagePNG& outputImage) override;

    bool halt() override;
    bool resume() override;
    bool suspend() override;
    bool reset() override;
};

#endif
