#ifndef OPCUA_SKILLS_CAMERA_IMAGE_FRAME_SKILL_H
#define OPCUA_SKILLS_CAMERA_IMAGE_FRAME_SKILL_H

#include <skills/camera/ImageSkill.hpp>
#include <functional>

namespace pnp{
    namespace opcua{
        namespace skill{
            namespace camera{
                class ImageStreamSkill;

                class ImageStreamSkillImpl : virtual public SkillImpl
                {
                public:
                    friend class ImageStreamSkill;

                protected:
                    virtual bool start(
                        const UA_UInt16& fps
                    ) = 0;

                    virtual bool halt() = 0;
                    virtual bool resume() = 0;
                    virtual bool suspend() = 0;
                    virtual bool reset() = 0;

                    std::function<void()> streamFinished;
                    std::function<void()> streamErrored;
                };


                class ImageStreamSkill : virtual public ImageSkill
                {
                protected:
                    SkillParameter<uint16_t> fpsParameter;

                    virtual UA_StatusCode readParameters() override
                    {
                        UA_StatusCode ret = ImageSkill::readParameters();

                        if(ret != UA_STATUSCODE_GOOD)
                            return ret;

                        ret = readParameter<uint16_t>(
                            fpsParameter,
                            [this](const uint16_t x)
                            {
                                fpsParameter.value = x;
                            }
                        );

                        return ret;
                    }

                public:
                    explicit ImageStreamSkill(
                        const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
                        std::shared_ptr<spdlog::logger>& logger,
                        const UA_NodeId& skillNodeId,
                        const std::string& eventSourceName
                    ) : SkillBase(server, logger, skillNodeId, eventSourceName),
                        ImageSkill(server, logger, skillNodeId, eventSourceName),
                        fpsParameter(&UA_TYPES[UA_TYPES_UINT16], "FPS",
                            UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                             const_cast<char*>("FPS"))))
                    {
                        
                    }

                    virtual void setImpl(
                        ImageStreamSkillImpl *impl,
                        std::function<void()> implDeleter
                    )
                    {
                        SkillBase::setImpl(impl, std::move(implDeleter));

                        this->startCallback = [impl, this]() {
                            if (this->readParameters() != UA_STATUSCODE_GOOD)
                                return false;
                            return impl->start(this->fpsParameter.value);
                        };
                        this->haltCallback = std::bind(
                                &ImageStreamSkillImpl::halt, impl);
                        this->resumeCallback = std::bind(
                                &ImageStreamSkillImpl::resume, impl);
                        this->suspendCallback = std::bind(
                                &ImageStreamSkillImpl::suspend, impl);
                        this->resetCallback = std::bind(
                                &ImageStreamSkillImpl::reset, impl);
                        impl->streamErrored = std::bind(
                                &ImageSkill::imageErrored, this);
                        impl->streamFinished = std::bind(
                                &ImageSkill::imageFinished, this);
                    }
                };
            }
        }
    }
}

#endif