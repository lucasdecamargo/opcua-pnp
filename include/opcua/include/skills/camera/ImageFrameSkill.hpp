#ifndef OPCUA_SKILLS_CAMERA_IMAGE_FRAME_SKILL_H
#define OPCUA_SKILLS_CAMERA_IMAGE_FRAME_SKILL_H

#include <skills/camera/ImageSkill.hpp>
#include <functional>

namespace pnp{
    namespace opcua{
        namespace skill{
            namespace camera{
                
                class ImageFrameSkill;

                class ImageFrameSkillImpl: virtual public SkillImpl
                {
                public:
                    friend class ImageFrameSkill;
                
                protected:
                    virtual bool start(const std::string format) = 0;
                    virtual bool halt() = 0;
                    virtual bool resume() = 0;
                    virtual bool suspend() = 0;
                    virtual bool reset() = 0;

                    std::function<void()> frameFinished;
                    std::function<void()> frameErrored;
                };

                
                class ImageFrameSkill: virtual public ImageSkill
                {
                protected:
                    UA_StatusCode readParameters() override
                    {
                        return ImageSkill::readParameters();
                    }

                public:
                    explicit ImageFrameSkill(
                        const std::shared_ptr<pnp::opcua::OpcUaServer> &server,
                        std::shared_ptr<spdlog::logger> &logger,
                        const UA_NodeId &skillNodeId,
                        const std::string &eventSourceName
                    )
                        : SkillBase(server, logger, skillNodeId, eventSourceName),
                          ImageSkill(server, logger, skillNodeId, eventSourceName)
                    {
                        // ...
                    }

                    virtual void setImpl(
                        ImageFrameSkillImpl *impl,
                        std::function<void()> implDeleter = nullptr
                    )
                    {
                        SkillBase::setImpl(impl, std::move(implDeleter));

                        this->startCallback = [impl, this]() {
                            if (this->readParameters() != UA_STATUSCODE_GOOD)
                                return false;
                            return impl->start(this->formatParameter.value);
                        };
                        this->haltCallback = std::bind(
                                &ImageFrameSkillImpl::halt, impl);
                        this->resumeCallback = std::bind(
                                &ImageFrameSkillImpl::resume, impl);
                        this->suspendCallback = std::bind(
                                &ImageFrameSkillImpl::suspend, impl);
                        this->resetCallback = std::bind(
                                &ImageFrameSkillImpl::reset, impl);
                        impl->frameErrored = std::bind(
                                &ImageSkill::imageErrored, this);
                        impl->frameFinished = std::bind(
                                &ImageSkill::imageFinished, this);
                    }
                };
            }
        }
    }
}

#endif