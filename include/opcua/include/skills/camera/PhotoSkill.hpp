#ifndef OPCUA_SKILLS_CAMERA_PHOTO_SKILL_H
#define OPCUA_SKILLS_CAMERA_PHOTO_SKILL_H

#include <SkillBase.hpp>
#include <functional>

#define NAMESPACE_URI_CAMERA "https://pnp.org/UA/Camera/"

namespace pnp{
    namespace opcua{
        namespace skill{
            namespace camera{
                class PhotoSkill;

                class PhotoSkillImpl: virtual public SkillImpl
                {
                public:
                    friend class PhotoSkill;

                protected:
                    virtual bool start() = 0;
                    virtual bool halt() = 0;
                    virtual bool resume() = 0;
                    virtual bool suspend() = 0;
                    virtual bool reset() = 0;

                    std::function<void()> photoFinished;
                    std::function<void()> photoErrored;
                };

                class PhotoSkill : virtual public SkillBase
                {
                protected:
                    const size_t nsDiIdx;
                    const size_t nsCameraId;

                    UA_StatusCode readParameters() override
                    {
                        return UA_STATUSCODE_GOOD;
                    }

                public:
                    explicit PhotoSkill(
                        const std::shared_ptr<pnp::opcua::OpcUaServer> &server,
                        std::shared_ptr<spdlog::logger> &logger,
                        const UA_NodeId &skillNodeId,
                        const std::string &eventSourceName
                    )
                        : SkillBase(server, logger, skillNodeId, eventSourceName),
                        nsDiIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_DI)),
                        nsCameraId(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_CAMERA))
                    {
                        auto selfProgram = dynamic_cast<Program*>(this);

                        LockedServer ls = server->getLocked();
                        if (UA_Server_setNodeContext(ls.get(), skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                            throw std::runtime_error("Adding method context failed");
                        }
                    }

                    void photoFinished()
                    {
                        if (!transition(ProgramStateNumber::READY)) {
                            logger->error("Failed to make transition after camera has finished to ready");
                        }
                    }

                    void photoErrored()
                    {
                        if (!transition(ProgramStateNumber::HALTED)) {
                            logger->error("Failed to make transition after camera has finished to halted");
                        }

                        if (!transition(ProgramStateNumber::READY)) {
                            logger->error("Failed to make transition back to ready");
                        }
                    }

                    
                    virtual void setImpl(
                        PhotoSkillImpl *impl,
                        std::function<void()> implDeleter = nullptr
                    )
                    {
                        SkillBase::setImpl(impl, std::move(implDeleter));

                        this->startCallback = std::bind(
                                &PhotoSkillImpl::start, impl);
                        this->haltCallback = std::bind(
                                &PhotoSkillImpl::halt, impl);
                        this->resumeCallback = std::bind(
                                &PhotoSkillImpl::resume, impl);
                        this->suspendCallback = std::bind(
                                &PhotoSkillImpl::suspend, impl);
                        this->resetCallback = std::bind(
                                &PhotoSkillImpl::reset, impl);
                                
                        impl->photoErrored = std::bind(
                                &PhotoSkill::photoErrored, this);
                        impl->photoFinished = std::bind(
                                &PhotoSkill::photoFinished, this);
                    }
                };
            }
        }
    }
}


#endif