#include <client/RegisteredComponent.h>
#include <open62541/client_subscriptions.h>
#include <helper.hpp>
#include <open62541/client_highlevel.h>
#include <device_model_nodeids.h>

RegisteredComponent::~RegisteredComponent()
{
    monitorOnlineStop();
    disconnectClient();
}

bool RegisteredComponent::monitorOnline(std::chrono::milliseconds checkInterval) {
    if (this->monitorThreadRunning)
        return false;
    if (checkInterval.count() <= 0)
        return false;
    if (!this->client.data().get())
        return false;

    if (!createServerStateSubscription(checkInterval)) {
        return false;
    }

    this->monitorThreadRunning = true;
    long interval = (long)checkInterval.count();

    this->monitorOnlineThread = std::thread([&, interval]() {


        while(this->monitorThreadRunning) {
            if (!this->checkOnline(std::chrono::milliseconds(interval))) {
                if (this->offlineCallback)
                    this->offlineCallback();
                break;
            }
            std::this_thread::sleep_for(std::chrono::milliseconds(interval));
        }
        this->monitorThreadRunning = false;
    });
    return true;
}

void RegisteredComponent::monitorOnlineStop() {
    if (!this->monitorThreadRunning)
        return;

    this->monitorThreadRunning = false;

    if (subId == 0)
        return;
    {
        LockedClient lc = this->getLockedClient();
        UA_Client_Subscriptions_deleteSingle(lc.get(), subId);
    }
    subId = 0;
    monId = 0;
}

bool RegisteredComponent::createServerStateSubscription(std::chrono::milliseconds checkInterval) {
    if (subId != 0 || monId != 0)
        return false;

    /* Create a subscription */
    UA_CreateSubscriptionRequest subRequest = UA_CreateSubscriptionRequest_default();
    subRequest.requestedPublishingInterval = (double)checkInterval.count();
    subRequest.maxNotificationsPerPublish = 1;
    UA_CreateSubscriptionResponse subResponse;
    {
        LockedClient lc = this->getLockedClient();
        subResponse = UA_Client_Subscriptions_create(lc.get(), subRequest,
                                                                                   this, nullptr, nullptr);
    }
    if (subResponse.responseHeader.serviceResult != UA_STATUSCODE_GOOD) {
        logger->error("Failed to create monitor-online subscription: {}", UA_StatusCode_name(subResponse.responseHeader.serviceResult));
        return false;
    }

    subId = subResponse.subscriptionId;

    /* Add a MonitoredItem */
    UA_MonitoredItemCreateRequest item =
            UA_MonitoredItemCreateRequest_default(UA_NODEID_NUMERIC(0, UA_NS0ID_SERVER_SERVERSTATUS_CURRENTTIME));
    item.requestedParameters.samplingInterval = (double)checkInterval.count();
    UA_MonitoredItemCreateResult result;
    {
        LockedClient lc = this->getLockedClient();
        result =
                UA_Client_MonitoredItems_createDataChange(lc.get(), subResponse.subscriptionId,
                                                          UA_TIMESTAMPSTORETURN_BOTH,
                                                          item, NULL, RegisteredComponent::handler_TimeChanged, NULL);
    }

    if (result.statusCode != UA_STATUSCODE_GOOD) {
        logger->error("Failed to add MonitoredItem, status code {}", UA_StatusCode_name(result.statusCode));
        return false;
    }

    monId = result.monitoredItemId;

    UA_MonitoredItemCreateResult_clear(&result);

    return true;
}


void RegisteredComponent::handler_TimeChanged(UA_Client *client, UA_UInt32 subId, void *subContext,
                                UA_UInt32 monId, void *monContext, UA_DataValue *value) {
    if (!subContext)
        return;

    RegisteredComponent *self = static_cast<RegisteredComponent*>(subContext);
    self->lastTimeUpdate = std::chrono::steady_clock::now();
}

bool RegisteredComponent::checkOnline(std::chrono::milliseconds checkInterval) {
    if (!this->client.data().get())
        return false;
    if (subId == 0 || monId == 0)
        return false;

    LockedClient lc = this->getLockedClient();


    UA_SecureChannelState channelState;
    UA_SessionState sessionState;
    UA_StatusCode connectStatus;
    UA_Client_getState(lc.get(), &channelState, &sessionState, &connectStatus);

    if (channelState == UA_SECURECHANNELSTATE_CLOSED) {
        return false;
    }
    UA_StatusCode retVal;
    retVal = UA_Client_run_iterate(lc.get(), 0);
    if (retVal != UA_STATUSCODE_GOOD) {
        logger->error("Client_run_iterate error: {}", UA_StatusCode_name(retVal));
        return false;
    }

    double diff = (double)std::chrono::duration_cast<std::chrono::milliseconds>(std::chrono::steady_clock::now() - lastTimeUpdate).count();
    return diff < (double)checkInterval.count() * 1.5;
}

bool RegisteredComponent::ensureConnected() {

    LockedClient lc = this->getLockedClient();

    UA_SecureChannelState channelState;
    UA_SessionState sessionState;
    UA_StatusCode connectStatus;
    UA_Client_getState(lc.get(), &channelState, &sessionState, &connectStatus);
    if (sessionState >= UA_SESSIONSTATE_ACTIVATED) {
        UA_Client_run_iterate(lc.get(), 5);
        UA_Client_getState(lc.get(), &channelState, &sessionState, &connectStatus);
        if (sessionState >= UA_SESSIONSTATE_ACTIVATED) {
            return true;
        }
    }

    logger->info("Client lost connecion. Trying to reconnect...");


    UA_StatusCode retval = UA_Client_connect(lc.get(), endpointUrl.c_str());
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Can not connect to {}. Error {}", endpointUrl.c_str(), UA_StatusCode_name(retval));
        return false;
    }

    return true;
}

void RegisteredComponent::disconnectClient() {
    if (clientUnsafe) {
        UA_Client_disconnect(clientUnsafe);
        UA_Client_delete(clientUnsafe);
    }
    clientUnsafe = nullptr;
    this->client = MutexedClient(nullptr);
}

bool RegisteredComponent::connectClient() {
    if (clientUnsafe)
        return true;

    clientUnsafe = pnp::opcua::UA_Helper_getClientForEndpoint(
            endpoint.get(),
            loggerOpcua,
            clientCertPath,
            clientKeyPath,
            clientAppUri,
            clientAppName
    );

    client = MutexedClient(clientUnsafe);

    UA_StatusCode retval = UA_Client_connect(client.data().get(), endpointUrl.c_str());
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Can not connect to {}: {}", endpointUrl, UA_StatusCode_name(retval));
        UA_Client_delete(client.data().get());
        client.data() = nullptr;
        return false;
    }

    return true;
}

