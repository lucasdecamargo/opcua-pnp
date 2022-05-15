#ifndef OPCUA_CLIENT_GENERICSKILLCLIENT_H
#define OPCUA_CLIENT_GENERICSKILLCLIENT_H

#include <client/SkillClient.h>

class GenericSkillClient : public SkillClient {
private:
    std::map<const std::string, SkillClientParameter*> parameterMap;

    void populateParametersMap(bool disconnectAfterInit);
public:
    explicit GenericSkillClient(
            std::shared_ptr<spdlog::logger>& loggerApp,
            std::shared_ptr<spdlog::logger>& loggerOpcua,
            const std::string& serverURL,
            const UA_NodeId& _skillNodeId,
            UA_Client *clientParam,
            const std::string &username = "",
            const std::string &password = "",
            bool disconnectAfterInit = true);

    UA_StatusCode setParameterValue(const std::string &name, const UA_Variant& value);

    UA_StatusCode writeParameterSet();
};

#endif