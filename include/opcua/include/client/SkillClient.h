#ifndef OPCUA_CLIENT_SKILLCLIENT_H
#define OPCUA_CLIENT_SKILLCLIENT_H

#include <string>
#include <future>
#include <memory>
#include <queue>
#include <spdlog/logger.h>
#include <open62541/client.h>

#include <ProgramState.hpp>
#include <ProgramTransition.hpp>

#include <client/SkillClientParameter.h>


class SkillClient {
public:
    explicit SkillClient(std::shared_ptr<spdlog::logger> _loggerApp,
                         std::shared_ptr<spdlog::logger> _loggerOpcua,
                         const std::string &serverURL,
                         UA_UInt16 nsIdxDi,
                         const UA_NodeId &skillNodeId,
                         const std::string &username = "",
                         const std::string &password = "",
                         bool isParameterSetMandatory = true,
                         UA_Client *client = NULL);
    explicit SkillClient(std::shared_ptr<spdlog::logger> _loggerApp,
                         std::shared_ptr<spdlog::logger> _loggerOpcua,
                         const std::string &serverURL,
                         UA_UInt16 nsIdxDi,
                         const UA_NodeId &skillNodeId,
                         const std::string &username = "",
                         const std::string &password = "",
                         const std::string& clientCertPath = "",
                         const std::string& clientKeyPath = "",
                         const std::string& clientAppUri = "",
                         const std::string& clientAppName = "");


    virtual ~SkillClient();

    bool step(UA_UInt16 timeout);

    void setEventFoundCallback(const std::function<bool(const pnp::opcua::ProgramStateNumber)> &callback);

    UA_StatusCode start();
    UA_StatusCode halt();
    UA_StatusCode reset();
    std::future<void> resetWait();
    UA_StatusCode resume();
    UA_StatusCode suspend();

    UA_StatusCode
    connect(bool addSubscription = true);
    UA_StatusCode disconnect();
    UA_StatusCode runThreaded();
    void stopThreaded();

    const pnp::opcua::ProgramStateNumber getCurrentState();

    UA_StatusCode readVariable(const UA_NodeId& node, UA_Variant* data);
    const pnp::opcua::ProgramTransitionNumber getLastTransition();

    std::future<pnp::opcua::ProgramStateNumber> getNextState();
    void emptyReceivedStates();

    std::future<UA_StatusCode> getFinalResultData(const UA_String& resultData, UA_Variant *data, bool disconnectAfter);

protected:
    UA_Client *client;
    std::recursive_mutex clientMutex;
    UA_UInt32 monId;
    UA_UInt32 subId;

    UA_NodeId *stateTransitionEventTypes = nullptr;
    size_t stateTransitionEventTypesCount = 0;

    UA_UInt16 nsIdxDi = 0;

    UA_NodeId skillNodeId;

    UA_NodeId startMethodId = UA_NODEID_NULL;
    UA_NodeId resetMethodId = UA_NODEID_NULL;
    UA_NodeId suspendMethodId = UA_NODEID_NULL;
    UA_NodeId resumeMethodId = UA_NODEID_NULL;
    UA_NodeId haltMethodId = UA_NODEID_NULL;

    UA_NodeId currentStateId = UA_NODEID_NULL;
    UA_NodeId currentStateNumberId = UA_NODEID_NULL;
    UA_NodeId lastTransitionNumberId = UA_NODEID_NULL;

    UA_NodeId parameterSetNodeId = UA_NODEID_NULL;

    UA_NodeId finalResultDataNodeId = UA_NODEID_NULL;

    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;

    std::function<bool(const pnp::opcua::ProgramStateNumber)> eventFoundCallback;

    void eventHandler(UA_UInt32 subId, UA_UInt32 monId, void *monContext,
                              size_t nEventFields, UA_Variant *eventFields);

    void handleTransitionEvent(const UA_DateTime *time,
                               const UA_LocalizedText *message,
                               const UA_LocalizedText *fromState,
                               const UA_LocalizedText *toState,
                               const UA_LocalizedText *transition);

    std::vector<SkillClientParameter*> parameter;

    UA_StatusCode writeParameter();

    bool initParameter(SkillClientParameter** param, const std::string &name, const UA_QualifiedName &browseName);

private:
    static void eventHandlerCallback(UA_Client *client,
                                     UA_UInt32 subId, void *subContext,
                                     UA_UInt32 monId, void *monContext,
                                     size_t nEventFields, UA_Variant *eventFields);

    std::string serverURL;
    std::string username;
    std::string password;

    std::mutex receivedStatesMutex;
    std::queue<pnp::opcua::ProgramStateNumber> receivedStates;
    std::condition_variable receivedStateAvailable;

    void initNodes(bool isParameterSetMandatory = true);

    UA_StatusCode addEventSubscription();
    void removeEventSubscription();

    static bool getEventFilter(UA_EventFilter *filter);
    static void setupOfTypeFilter(UA_ContentFilterElement *element, UA_UInt16 nsIndex, UA_UInt32 typeId);
    static UA_StatusCode setupWhereClause(UA_ContentFilter *contentFilter);
    static UA_StatusCode setupOperandArrays(UA_ContentFilter *contentFilter);

    bool running;
    std::thread stepperThread;

    void threadWorker();
};

#endif