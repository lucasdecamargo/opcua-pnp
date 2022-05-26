#ifndef PNP_RTMARKERDETECTIONSKILL_HPP
#define PNP_RTMARKERDETECTIONSKILL_HPP

#include <SkillBase.hpp>
#include <SkillParameter.hpp>

#include <utility>

#define NAMESPACE_URI_COMPOSITE_SKILLS "https://pnp.org/UA/CompositeSkills/"

namespace pnp {
    namespace opcua {
        namespace skill {
            namespace composed {

                class RTMarkerDetectionSkill;

                class RTMarkerDetectionSkillImpl : virtual public SkillImpl
                {
                public:
                    friend class RTMarkerDetectionSkill;

                protected:
                    virtual bool start(
                        const std::string& cameraControllerEndpoints,
                        const std::string& imageProcessorEndpoint
                    ) = 0;

                    virtual bool halt() = 0;
                    virtual bool resume() = 0;
                    virtual bool suspend() = 0;
                    virtual bool reset() = 0;

                    std::function<void()> finished;
                    std::function<void()> errored;
                };


                class RTMarkerDetectionSkill : virtual public SkillBase
                {
                protected:
                    const size_t nsDiIdx;
                    const size_t nsCompositeSkillsId;

                    const std::shared_ptr<UA_NodeId> parameterSetNodeId;

                    SkillParameter<std::string> imageControllerEndpoints;
                    SkillParameter<std::string> imageProcessorEndpoint;

                    UA_StatusCode readParameters() override
                    {
                        UA_StatusCode retval = readParameter<std::string, UA_String>(
                            imageControllerEndpoints,
                            [this](const UA_String& x)
                            {
                                if(x.length == 0)
                                    this->imageControllerEndpoints.value = "";
                                else
                                    this->imageControllerEndpoints.value = std::string((char*) x.data, x.length);
                            }
                        );
                        if(retval != UA_STATUSCODE_GOOD) return retval;

                        retval = readParameter<std::string, UA_String>(
                            imageProcessorEndpoint,
                            [this](const UA_String& x)
                            {
                                if(x.length == 0)
                                    this->imageProcessorEndpoint.value = "";
                                else
                                    this->imageProcessorEndpoint.value = std::string((char*) x.data, x.length);
                            }
                        );

                        return retval;
                    }

                public:
                    explicit RTMarkerDetectionSkill(
                        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
                        std::shared_ptr<spdlog::logger>& logger,
                        const UA_NodeId& skillNodeId,
                        const std::string& eventSourceName
                    ) :
                        SkillBase(server, logger, skillNodeId, eventSourceName),
                        nsDiIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_DI)),
                        nsCompositeSkillsId(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_COMPOSITE_SKILLS)),
                        parameterSetNodeId(UA_Server_getObjectComponentId(server, skillNodeId,
                                                                          UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                                                                           const_cast<char*>("ParameterSet")))),
                        imageControllerEndpoints(&UA_TYPES[UA_TYPES_STRING], "CameraSkillControllerEndpoints",
                                               UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsCompositeSkillsId),
                                                                              const_cast<char*>("CameraSkillControllerEndpoints")))),
                        imageProcessorEndpoint(&UA_TYPES[UA_TYPES_STRING], "ImageProcessorEndpoint",
                                               UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsCompositeSkillsId),
                                                                              const_cast<char*>("ImageProcessorEndpoint"))))
                    {
                        auto selfProgram = dynamic_cast<Program*>(this);

                        LockedServer ls = server->getLocked();
                        if (UA_Server_setNodeContext(ls.get(), skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                            throw std::runtime_error("Adding method context failed");
                        }
                    }

                    void finished()
                    {
                        if (!transition(ProgramStateNumber::READY))
                            logger->error("Failed to make transition after RTMarkerDector has finished to ready");
                    }

                    void errored()
                    {
                        if (!transition(ProgramStateNumber::READY))
                            logger->error("Failed to make transition after RTMarkerDector has failed to ready");
                    }

                    virtual void setImpl(
                        RTMarkerDetectionSkillImpl *impl,
                        std::function<void()> implDeleter
                        )
                    {
                        SkillBase::setImpl(impl, std::move(implDeleter));

                        this->startCallback = 
                            [impl, this]()
                            {
                                if(this->readParameters() != UA_STATUSCODE_GOOD) return false;
                                return impl->start(
                                    this->imageControllerEndpoints.value,
                                    this->imageProcessorEndpoint.value
                                );
                            };
                        
                        this->haltCallback = std::bind(
                                &RTMarkerDetectionSkillImpl::halt, impl);
                        this->resumeCallback = std::bind(
                                &RTMarkerDetectionSkillImpl::resume, impl);
                        this->suspendCallback = std::bind(
                                &RTMarkerDetectionSkillImpl::suspend, impl);
                        this->resetCallback = std::bind(
                                &RTMarkerDetectionSkillImpl::reset, impl);

                        impl->finished = std::bind(&RTMarkerDetectionSkill::finished, this);
                        impl->errored = std::bind(&RTMarkerDetectionSkill::errored, this);
                    }
                };
            }
        }
    }
}

#endif