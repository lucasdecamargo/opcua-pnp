#ifndef OPCUA_SKILL_PARAMETER_HPP
#define OPCUA_SKILL_PARAMETER_HPP

#include <utility>

namespace pnp {

    namespace opcua {
        namespace skill {

            template<typename T>
            class SkillParameter {

            public:
                T value;
                const UA_DataType* type;
                const std::string name;
                const std::shared_ptr<UA_NodeId> nodeId;

                explicit SkillParameter(
                        const UA_DataType* type,
                        std::string name,
                        const std::shared_ptr<UA_NodeId> nodeId
                ) :
                        value(), type(type), name(std::move(name)), nodeId(nodeId) {
                }
            };
        }
    }
}

#endif