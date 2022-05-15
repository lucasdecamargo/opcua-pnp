#ifndef OPCUA_SKILLS_MARKER_DETECTION_SKILL_H
#define OPCUA_SKILLS_MARKER_DETECTION_SKILL_H

#include <SkillBase.hpp>
#include <functional>

#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

#define NAMESPACE_URI_ARUCO "https://pnp.org/UA/ArUco/"

namespace pnp{
    namespace opcua{
        namespace skill{
            namespace image_processing{
                class MarkerDetectionSkill;

                class MarkerDetectionSkillImpl : virtual public SkillImpl
                {
                public:
                    friend class MarkerDetectionSkill;

                protected:
                    virtual bool start(UA_ImageDataType &inputImage, UA_CameraInfoDataType &cameraInfo, 
                                        UA_Boolean imageOutput, const std::shared_ptr<UA_NodeId> outputImageNodeId,
                                        UA_MarkerParametersDataType markerParameters, 
                                        UA_Boolean poseEstimation) = 0;
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
                    const size_t nsArucoId;

                    const std::shared_ptr<UA_NodeId> parameterSetNodeId;
                    SkillParameter<UA_ImageDataType> inputImageParameter;
                    SkillParameter<UA_ImageDataType> outputImageParameter;
                    SkillParameter<UA_CameraInfoDataType> cameraInfoParameter;
                    SkillParameter<UA_Boolean> poseEstimationParameter;
                    SkillParameter<UA_Boolean> imageOutputParameter;
                    SkillParameter<UA_MarkerParametersDataType> markerParametersParameter;

                    UA_StatusCode readParameters() override
                    {
                        UA_StatusCode ret = readParameter<UA_ImageDataType>(
                            inputImageParameter,
                            [this](const UA_ImageDataType& x)
                            {
                                UA_ImageDataType_clear(&this->inputImageParameter.value);
                                UA_ImageDataType_copy(&x, &this->inputImageParameter.value);
                            }
                        );

                        ret = readParameter<UA_ImageDataType>(
                            outputImageParameter,
                            [this](const UA_ImageDataType& x)
                            {
                                UA_ImageDataType_clear(&this->outputImageParameter.value);
                                UA_ImageDataType_copy(&x, &this->outputImageParameter.value);
                            }
                        );

                        ret = readParameter<UA_CameraInfoDataType>(
                            cameraInfoParameter,
                            [this](const UA_CameraInfoDataType& x)
                            {
                                UA_CameraInfoDataType_clear(&this->cameraInfoParameter.value);
                                UA_CameraInfoDataType_copy(&x, &this->cameraInfoParameter.value);
                            }
                        );

                        ret = readParameter<UA_Boolean>(
                            poseEstimationParameter,
                            [this](const UA_Boolean& x)
                            {
                                UA_Boolean_clear(&this->poseEstimationParameter.value);
                                UA_Boolean_copy(&x, &this->poseEstimationParameter.value);
                            }
                        );

                        ret = readParameter<UA_Boolean>(
                            imageOutputParameter,
                            [this](const UA_Boolean& x)
                            {
                                UA_Boolean_clear(&this->imageOutputParameter.value);
                                UA_Boolean_copy(&x, &this->imageOutputParameter.value);
                            }
                        );

                        ret = readParameter<UA_MarkerParametersDataType>(
                            markerParametersParameter,
                            [this](const UA_MarkerParametersDataType& x)
                            {
                                UA_MarkerParametersDataType_clear(&this->markerParametersParameter.value);
                                UA_MarkerParametersDataType_copy(&x, &this->markerParametersParameter.value);
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
                          nsArucoId(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_ARUCO)),
                          parameterSetNodeId(UA_Server_getObjectComponentId(server, stateMachineNodeId,
                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                             const_cast<char*>("ParameterSet")))),
                          inputImageParameter(&UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_IMAGEDATATYPE],
                                              "InputImage",
                                              UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsArucoId),
                                                const_cast<char*>("InputImage")))),
                          outputImageParameter(&UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_IMAGEDATATYPE],
                                              "OutputImage",
                                              UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsArucoId),
                                                const_cast<char*>("OutputImage")))),
                          cameraInfoParameter(&UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_CAMERAINFODATATYPE],
                                              "CameraInfo",
                                              UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsArucoId),
                                                const_cast<char*>("CameraInfo")))),
                          poseEstimationParameter(&UA_TYPES[UA_TYPES_BOOLEAN],
                                              "PoseEstimation",
                                              UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsArucoId),
                                                const_cast<char*>("PoseEstimation")))),
                          imageOutputParameter(&UA_TYPES[UA_TYPES_BOOLEAN],
                                              "ImageOutput",
                                              UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsArucoId),
                                                const_cast<char*>("ImageOutput")))),
                          markerParametersParameter(&UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_MARKERPARAMETERSDATATYPE],
                                              "MarkerParameters",
                                              UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsArucoId),
                                                const_cast<char*>("MarkerParameters"))))
                    {
                        auto selfProgram = dynamic_cast<Program*>(this);

                        LockedServer ls = server->getLocked();
                        if (UA_Server_setNodeContext(ls.get(), skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                            throw std::runtime_error("Adding method context failed");
                        }

                        UA_ImageDataType_init(&inputImageParameter.value);
                        UA_ImageDataType_init(&outputImageParameter.value);
                        UA_CameraInfoDataType_init(&cameraInfoParameter.value);
                        UA_Boolean_init(&poseEstimationParameter.value);
                        UA_Boolean_init(&imageOutputParameter.value);
                        UA_MarkerParametersDataType_init(&markerParametersParameter.value);
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
                            
                            return impl->start(this->inputImageParameter.value,
                                               this->cameraInfoParameter.value,
                                               this->imageOutputParameter.value,
                                               this->outputImageParameter.nodeId,
                                               this->markerParametersParameter.value,
                                               this->poseEstimationParameter.value);
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
