#ifndef OPCUA_SKILLS_CAMERA_IMAGE_SKILL_H
#define OPCUA_SKILLS_CAMERA_IMAGE_SKILL_H

#include <SkillBase.hpp>
#include <functional>

#define NAMESPACE_URI_CAMERA "https://pnp.org/UA/Camera/"

namespace pnp{
    namespace opcua{
        namespace skill{
            namespace camera{
                class ImageSkill : virtual public SkillBase
                {
                protected:
                    const size_t nsDiIdx;
                    const size_t nsCameraId;
                    const std::shared_ptr<UA_NodeId> parameterSetNodeId;
                    SkillParameter<std::string> formatParameter;

                    UA_StatusCode readParameters() override
                    {
                        UA_StatusCode ret = readParameter<std::string, UA_String>(
                            formatParameter,
                            [this](const UA_String& x)
                            {
                                if(x.length == 0)
                                    this->formatParameter.value = "";
                                else
                                    this->formatParameter.value = std::string((char*) x.data, x.length);
                            }
                        );

                        return ret;
                    }

                public:
                    explicit ImageSkill(
                        const std::shared_ptr<pnp::opcua::OpcUaServer> &server,
                        std::shared_ptr<spdlog::logger> &logger,
                        const UA_NodeId &skillNodeId,
                        const std::string &eventSourceName
                    )
                        : SkillBase(server, logger, skillNodeId, eventSourceName),
                        nsDiIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_DI)),
                        nsCameraId(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_CAMERA)),
                        parameterSetNodeId(UA_Server_getObjectComponentId(server, stateMachineNodeId,
                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                             const_cast<char*>("ParameterSet")))),
                        formatParameter(&UA_TYPES[UA_TYPES_STRING], "Format",
                            UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsCameraId),
                                             const_cast<char*>("Format"))))
                    {
                        auto selfProgram = dynamic_cast<Program*>(this);

                        LockedServer ls = server->getLocked();
                        if (UA_Server_setNodeContext(ls.get(), skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                            throw std::runtime_error("Adding method context failed");
                        }
                    }

                    void imageFinished()
                    {
                        if (!transition(ProgramStateNumber::READY)) {
                            logger->error("Failed to make transition after camera has finished to ready");
                        }
                    }

                    void imageErrored()
                    {
                        if (!transition(ProgramStateNumber::HALTED)) {
                            logger->error("Failed to make transition after camera has finished to halted");
                        }
                    }
                };
            }
        }
    }
}

#endif