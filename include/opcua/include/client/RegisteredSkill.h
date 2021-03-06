#ifndef OPCUA_CLIENT_REGISTEREDSKILL_H
#define OPCUA_CLIENT_REGISTEREDSKILL_H

#include <memory>
#include <open62541/types.h>

#include <spdlog/spdlog.h>
#include <client/GenericSkillClient.h>
#include <client/RegisteredComponent.h>
#include <client/SkillParameter.h>

class RegisteredSkill
{
private:
    std::shared_ptr<RegisteredComponent> parentComponent;
    UA_NodeId skillNodeId;
    UA_NodeId skillTypeId;
    UA_QualifiedName skillTypeName;
    UA_QualifiedName browseName;
    const std::string clientCertPath;
    const std::string clientKeyPath;
    const std::string clientAppUri;
    const std::string clientAppName;
    std::shared_ptr<spdlog::logger> logger;
    UA_NodeId skillControllerNodeId = UA_NODEID_NULL;
    UA_NodeId parameterSetNodeId = UA_NODEID_NULL;


    GenericSkillClient *skillClient = nullptr;
public:
    explicit RegisteredSkill(
            std::shared_ptr<RegisteredComponent> &parentComponent,
            std::shared_ptr<spdlog::logger> &logger,
            UA_NodeId &skillNodeId,
            const std::string& clientCertPath,
            const std::string& clientKeyPath,
            const std::string& clientAppUri,
            const std::string& clientAppName);
    virtual ~RegisteredSkill();

    const UA_NodeId& getSkillTypeId() {
        return skillTypeId;
    }
    std::string getSkillNameStr() {
        return std::string((char*)browseName.name.data, browseName.name.length);
    }
    const UA_QualifiedName& getSkillTypeName() {
        return skillTypeName;
    }
    std::string getSkillTypeNameStr() {
        return std::string((char*)skillTypeName.name.data, skillTypeName.name.length);
    }
    const UA_NodeId& getSkillId() {
        return skillNodeId;
    }

    std::shared_ptr<RegisteredComponent> getParentComponent() {
        return parentComponent;
    }

    const UA_NodeId getSkillControllerNodeId() {
        return skillControllerNodeId;
    }

    const UA_NodeId getParameterSetNodeId();

    void setSkillControllerNodeId(const UA_NodeId& node) {
        skillControllerNodeId = node;
    }

    std::future<bool> execute(
            std::shared_ptr<spdlog::logger>& loggerApp,
            std::shared_ptr<spdlog::logger>& loggerOpcua,
            const std::vector<std::shared_ptr<SkillParameter>>& parameters,
            const bool autoDisconnect = true,
            const UA_DataTypeArray* customDataTypes = NULL
    );

    std::future<UA_StatusCode> getFinalResultData(std::shared_ptr<spdlog::logger>& logger, const UA_String& resultData, UA_Variant *data);
};

#endif