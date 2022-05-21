#ifndef PNP_IMAGEPROCESSOR_H
#define PNP_IMAGEPROCESSOR_H

#include <OpcUaServer.h>
#include <libconfig.h++>

#include <MarkerDetectionSkillImpl.h>

class ImageProcessor
{
public:
    explicit ImageProcessor(
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
        const libconfig::Setting& imageProcessorSettings,
        const std::string& markersFilePath
    );

    virtual ~ImageProcessor();

    ImageProcessor(const ImageProcessor&) = delete;

    const libconfig::Setting& imageProcessorSettings;

private:
    UA_StatusCode initSkills();
    bool createNodesFromNodeset();

    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    std::shared_ptr<pnp::opcua::OpcUaServer> server;
    std::string markersFilePath;

    MarkerDetectionSkillImpl *markerDetectionSkillImpl{};
    std::unique_ptr<pnp::opcua::skill::image_processor::MarkerDetectionSkill> markerDetectionSkill;
};

#endif