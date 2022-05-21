#ifndef OPCUA_SKILLS_MARKER_DETECTION_SKILL_DEPR_H
#define OPCUA_SKILLS_MARKER_DETECTION_SKILL_DEPR_H

#include <SkillBase.hpp>
#include <functional>
#include <vector>

#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

#define NAMESPACE_URI_IMAGEPROCESSOR "https://pnp.org/UA/ImageProcessor/"

namespace pnp
{
    namespace opcua
    {
        namespace skill
        {
            namespace image_processor
            {

                class MarkerDetectionSkill;

                class MarkerDetectionSkillImpl : virtual public SkillImpl
                {
                public:
                    friend class MarkerDetectionSkill;
                
                protected:
                    virtual bool start( const UA_CameraInfoDataType& cameraInfo,
                                        const UA_ByteString& inputImage,
                                        std::vector<UA_MarkerDataType>& detectedMarkers,
                                        UA_ImagePNG* outputImage ) = 0;
                    virtual bool halt() = 0;
                    virtual bool resume() = 0;
                    virtual bool suspend() = 0;
                    virtual bool reset() = 0;

                    std::function<void()> detectionFinished;
                    std::function<void()> detectionErrored;
                };

                class MarkerDetectionSkill : virtual public SkillBase
                {
                protected:
                    const size_t nsDiIdx;
                    const size_t nsImageProcessorId;

                    const std::shared_ptr<UA_NodeId> parameterSetNodeId;

                    SkillParameter<UA_CameraInfoDataType> paramCameraInfo;
                    SkillParameter<UA_ByteString> paramInputImage;
                    SkillParameter<std::vector<UA_MarkerDataType>> paramDetectedMarkers;
                    SkillParameter<UA_ImagePNG> paramOutputImage;

                    UA_StatusCode readParameters() override
                    {
                        UA_StatusCode ret;

                        ret = readParameter<UA_CameraInfoDataType>(
                            paramCameraInfo,
                            [this](const UA_CameraInfoDataType& p)
                            {
                                if(p.cameraMatrixSize != 9 || p.distortionCoefficientsSize < 5)
                                    return;
                                if(p.cameraMatrix == NULL || p.distortionCoefficients == NULL)
                                    return;
                                
                                if(this->paramCameraInfo.value.distortionCoefficients != NULL)
                                    UA_free(this->paramCameraInfo.value.distortionCoefficients);
                                if(this->paramCameraInfo.value.cameraMatrix != NULL)
                                    UA_free(this->paramCameraInfo.value.cameraMatrix);

                                this->paramCameraInfo.value.distortionCoefficientsSize = p.distortionCoefficientsSize;
                                this->paramCameraInfo.value.distortionCoefficientsSize = 9;

                                UA_Array_copy(p.distortionCoefficients, p.distortionCoefficientsSize,
                                                (void**)(this->paramCameraInfo.value.distortionCoefficients),
                                                &UA_TYPES[UA_TYPES_DOUBLE]);

                                UA_Array_copy(p.cameraMatrix, 9,
                                                (void**)(this->paramCameraInfo.value.cameraMatrix),
                                                &UA_TYPES[UA_TYPES_DOUBLE]);
                                
                            }
                        );

                        if(ret != UA_STATUSCODE_GOOD) return ret;

                        ret = readParameter<UA_ByteString>(
                            paramInputImage,
                            [this](const UA_ByteString& p)
                            {
                                if(p.length <= 0 || p.data == NULL) return;

                                if(this->paramInputImage.value.data != NULL)
                                    UA_ByteString_clear(&this->paramInputImage.value);

                                UA_ByteString_copy(&p, &this->paramInputImage.value);
                            }
                        );

                        return ret;
                    }

                public:
                    explicit MarkerDetectionSkill(
                        const std::shared_ptr<pnp::opcua::OpcUaServer> &server,
                        std::shared_ptr<spdlog::logger> &logger,
                        const UA_NodeId &skillNodeId,
                        const std::string &eventSourceName
                    )
                      : SkillBase(server, logger, skillNodeId, eventSourceName),
                        nsDiIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_DI)),
                        nsImageProcessorId(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_IMAGEPROCESSOR)),
                        parameterSetNodeId(UA_Server_getObjectComponentId(server, stateMachineNodeId,
                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                             const_cast<char*>("ParameterSet")))),
                        paramCameraInfo(&UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_CAMERAINFODATATYPE],
                                        "CameraInfo",
                                        UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsImageProcessorId),
                                            const_cast<char*>("CameraInfo")))),
                        paramInputImage(&UA_TYPES[UA_TYPES_BYTESTRING],
                                        "InputImage",
                                        UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsImageProcessorId),
                                            const_cast<char*>("InputImage")))),
                        paramDetectedMarkers(&UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_MARKERDATATYPE],
                                        "DetectedMarkersArray",
                                        UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsImageProcessorId),
                                            const_cast<char*>("DetectedMarkersArray")))),
                        paramOutputImage(&UA_TYPES[UA_TYPES_IMAGEPNG],
                                        "OutputImage",
                                        UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsImageProcessorId),
                                            const_cast<char*>("OutputImage"))))
                    {
                        auto selfProgram = dynamic_cast<Program*>(this);

                        LockedServer ls = server->getLocked();
                        if (UA_Server_setNodeContext(ls.get(), skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                            throw std::runtime_error("Adding method context failed");
                        }

                        paramCameraInfo.value.distortionCoefficientsSize = 5;
                        paramCameraInfo.value.distortionCoefficients = (UA_Double*)UA_malloc(5 * sizeof(UA_Double));
                        memset(&paramCameraInfo.value.distortionCoefficients,0,5);
                        paramCameraInfo.value.cameraMatrixSize = 9;
                        paramCameraInfo.value.cameraMatrix = (UA_Double*)UA_malloc(9 * sizeof(UA_Double));
                        memset(&paramCameraInfo.value.cameraMatrix,0,9);
                        paramCameraInfo.value.cameraMatrix[0] = 1;
                        paramCameraInfo.value.cameraMatrix[4] = 1;
                        paramCameraInfo.value.cameraMatrix[8] = 1;

                        paramInputImage.value.length = 0;
                        paramInputImage.value.data = NULL;

                        paramOutputImage.value.length = 0;
                        paramOutputImage.value.data = NULL;
                    }

                    virtual void setImpl(
                        MarkerDetectionSkillImpl *impl,
                        std::function<void()> implDeleter
                    )
                    {
                        SkillBase::setImpl(impl, std::move(implDeleter));

                        this->startCallback = [impl, this]() {
                            if (this->readParameters() != UA_STATUSCODE_GOOD)
                                return false;
                            
                            return impl->start(this->paramCameraInfo.value,
                                               this->paramInputImage.value,
                                               this->paramDetectedMarkers.value,
                                               &this->paramOutputImage.value);
                        };

                        this->haltCallback = std::bind(
                                &MarkerDetectionSkillImpl::halt, impl);
                        this->resumeCallback = std::bind(
                                &MarkerDetectionSkillImpl::resume, impl);
                        this->suspendCallback = std::bind(
                                &MarkerDetectionSkillImpl::suspend, impl);
                        this->resetCallback = std::bind(
                                &MarkerDetectionSkillImpl::reset, impl);
                        impl->detectionErrored = std::bind(
                                &MarkerDetectionSkill::detectionErrored, this);
                        impl->detectionFinished = std::bind(
                                &MarkerDetectionSkill::detectionFinished, this);
                    }

                    void detectionFinished()
                    {
                        // Update output parameters
                        // ...

                        if (!transition(ProgramStateNumber::READY)) {
                            logger->error("Failed to make transition after marker detection has finished to ready");
                        }
                    }

                    void detectionErrored()
                    {
                        if (!transition(ProgramStateNumber::READY)) {
                            logger->error("Failed to make transition after marker detection has finished to ready");
                        }
                    }

                };

            }
        }
    }
}


#endif