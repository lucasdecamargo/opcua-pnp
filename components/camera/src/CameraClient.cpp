#include <CameraClient.h>

#include <camera_nodeids.h>
#include <skills/camera/PhotoSkill.hpp>

#include <open62541/client_highlevel.h>

#include <open62541/client_subscriptions.h>

const UA_DataTypeArray CameraClient::customDataTypes = {NULL, UA_TYPES_PNP_TYPES_COUNT, UA_TYPES_PNP_TYPES};

CameraClient::CameraClient(std::shared_ptr<spdlog::logger> _loggerApp,
                         std::shared_ptr<spdlog::logger> _loggerOpcua,
                         const std::string &serverURL,
                         const std::string &username,
                         const std::string &password,
                         const std::string& clientCertPath,
                         const std::string& clientKeyPath,
                         const std::string& clientAppUri,
                         const std::string& clientAppName) :
        logger(std::move(_loggerApp)), loggerOpcua(std::move(_loggerOpcua)),
        serverURL(serverURL), username(username), password(password),
        subId(0), monId(0)
{
    running = false;

    UA_EndpointDescription* description = pnp::opcua::getEndpointWithHighestSecurity(serverURL.c_str(), logger);

    client = pnp::opcua::UA_Helper_getClientForEndpoint(
            description,
            loggerOpcua,
            clientCertPath,
            clientKeyPath,
            clientAppUri,
            clientAppName,
            username,
            password
    );
    if (!client)
        throw std::runtime_error("Cannot connect camera client");

    UA_Client_getConfig(client)->customDataTypes = &customDataTypes;


    UA_EndpointDescription_delete(description);
}

CameraClient::~CameraClient()
{
    stop();
    UA_Client_delete(client);
}

UA_StatusCode CameraClient::connect()
{
    std::lock_guard<std::recursive_mutex> lk(clientMutex);

    UA_SecureChannelState channelState;
    UA_SessionState sessionState;
    UA_StatusCode connectStatus;
    UA_Client_getState(client, &channelState, &sessionState, &connectStatus);
    if (sessionState >= UA_SESSIONSTATE_ACTIVATED)
    {
        UA_Client_run_iterate(client, 5);
        UA_Client_getState(client, &channelState, &sessionState, &connectStatus);
        if (sessionState >= UA_SESSIONSTATE_ACTIVATED) 
            return UA_STATUSCODE_GOOD;
    }

    UA_StatusCode retval;

    int tryCount = 0;
    do {
        if (username.empty()) {
            if (!password.empty()) {
                logger->warn("Password provided but no user. Attempting to connect without login...");
            } else {
                logger->info("Attempting to connect without login...");
            }
            retval = UA_Client_connect(client, serverURL.c_str());
        } else {
            logger->info("Attempting to connect with username: {}", username);
            retval = UA_Client_connectUsername(client, serverURL.c_str(), username.c_str(), password.c_str());
        }
        if (retval == UA_STATUSCODE_BADCONNECTIONCLOSED) {
            logger->warn("Connection attempt to {} failed. Retrying ...", serverURL.c_str());
            // clean up any remaining connections and try again
            UA_Client_disconnect(client);
        }
        tryCount++;
    } while (tryCount < 2 && retval == UA_STATUSCODE_BADCONNECTIONCLOSED);

    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Can not connect to kb {}. Error {}", serverURL.c_str(), UA_StatusCode_name(retval));
        return retval;
    }

    logger->info("Camera Client connected");

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode CameraClient::disconnect()
{
    std::lock_guard<std::recursive_mutex> lk(clientMutex);
    logger->info("Camera Client disconnected");
    return UA_Client_disconnect(client);
}

bool CameraClient::step(UA_UInt16 timeout) {

    UA_SecureChannelState channelState;
    UA_SessionState sessionState;
    UA_StatusCode connectStatus;
    UA_Client_getState(client, &channelState, &sessionState, &connectStatus);

    if (channelState == UA_SECURECHANNELSTATE_CLOSED || sessionState == UA_SESSIONSTATE_CLOSED) {
        return true;
    }
    UA_StatusCode retVal;
    {
        std::lock_guard<std::recursive_mutex> lk(clientMutex);
        retVal = UA_Client_run_iterate(client, timeout);
    }
    if (retVal != UA_STATUSCODE_GOOD) {
        logger->error("Client_run_iterate error: {}", UA_StatusCode_name(retVal));
        return false;
    }
    return true;
}

UA_StatusCode CameraClient::stepAsync() 
{
    if (running)
        return UA_STATUSCODE_BADALREADYEXISTS;
    running = true;
    stepperThread = std::thread([&] { threadWorker(); });
    return UA_STATUSCODE_GOOD;
}

void CameraClient::stop()
{
    if (!running)
        return;
    running = false;
    stepperThread.join();
}

UA_StatusCode CameraClient::getNodeIds()
{
    UA_NodeId skillControllerNodeId = UA_NODEID_NUMERIC(5, UA_CAMERAID_CAMERADEVICE);

    UA_StatusCode retval = UA_STATUSCODE_GOOD;

    // Get ParameterSet NodeId
    UA_NodeId parameterSetNodeId;
    UA_UInt16 nsIdxDi;

    UA_String nsUriDi = UA_String_fromChars(NAMESPACE_URI_DI);
    {
        std::lock_guard<std::recursive_mutex> lk(clientMutex);
        retval = UA_Client_NamespaceGetIndex(client, &nsUriDi, &nsIdxDi);
    }

    if(retval != UA_STATUSCODE_GOOD)
        throw std::runtime_error("Failed get namespace index for DI Namespace. " + std::string(UA_StatusCode_name(retval)));
    
    {
        std::lock_guard<std::recursive_mutex> lk(clientMutex);
        if(!pnp::opcua::UA_Client_findChildWithBrowseName(
            client, logger, skillControllerNodeId,
            UA_QUALIFIEDNAME(nsIdxDi,
            const_cast<char *>("ParameterSet")),
            &parameterSetNodeId))
            throw std::runtime_error("Could not find Cameras ParameterSet NodeId");
    }

    nodeIds.clear();

    UA_UInt16 nsIdxCamera;
    UA_String nsUriCamera = UA_String_fromChars("https://pnp.org/UA/Camera/");

    {
        std::lock_guard<std::recursive_mutex> lk(clientMutex);
        retval = UA_Client_NamespaceGetIndex(client, &nsUriCamera, &nsIdxCamera);
    }
    UA_String_clear(&nsUriCamera);

    if (retval != UA_STATUSCODE_GOOD)
        throw std::runtime_error("Failed get namespace index for Camera Namespace." + std::string(UA_StatusCode_name(retval)));


    std::lock_guard<std::recursive_mutex> lk(clientMutex);
    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        client, logger, skillControllerNodeId,
        UA_QUALIFIEDNAME(nsIdxCamera,
        const_cast<char *>("ImagePNG")),
        &nodeIds["ImagePNG"]))
        logger->error("Could not find ImagePNG NodeId");
    
    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        client, logger, parameterSetNodeId,
        UA_QUALIFIEDNAME(nsIdxCamera,
        const_cast<char *>("CameraInfo")),
        &nodeIds["CameraInfo"]))
        logger->error("Could not find CameraInfo NodeId");
    
    if(!pnp::opcua::UA_Client_findChildWithBrowseName(
        client, logger, parameterSetNodeId,
        UA_QUALIFIEDNAME(nsIdxCamera,
        const_cast<char *>("CameraPose")),
        &nodeIds["CameraPose"]))
        logger->error("Could not find CameraInfo NodeId");

    return retval;
} 


UA_StatusCode CameraClient::readVariable(const UA_NodeId& node, UA_Variant* data)
{
    UA_ReadRequest request;
    UA_ReadRequest_init(&request);
    request.nodesToReadSize = 1;
    request.nodesToRead = UA_ReadValueId_new();
    UA_ReadValueId_init(request.nodesToRead);
    UA_NodeId_copy(&node, &request.nodesToRead->nodeId);
    request.nodesToRead->attributeId = UA_ATTRIBUTEID_VALUE;
    UA_ReadResponse response;
    {
        std::lock_guard<std::recursive_mutex> lk(clientMutex);
        response = UA_Client_Service_read(client, request);
    }
    UA_ReadRequest_clear(&request);

    if (response.responseHeader.serviceResult != UA_STATUSCODE_GOOD) {
        UA_ReadResponse_clear(&response);
        return response.responseHeader.serviceResult;
    }


    if (response.resultsSize != 1) {
        UA_ReadResponse_clear(&response);
        return UA_STATUSCODE_BADINVALIDSTATE;
    }

    UA_StatusCode retval = UA_Variant_copy(&response.results[0].value, data);
    UA_ReadResponse_clear(&response);
    return retval;
}

UA_StatusCode CameraClient::readImageNode(UA_ImagePNG *image)
{
    UA_UInt16 nsCamera;

    {
        std::lock_guard<std::recursive_mutex> lk(clientMutex);
        UA_String nsCameraUri = UA_String_fromChars(NAMESPACE_URI_CAMERA);
        UA_Client_NamespaceGetIndex(client, &nsCameraUri, &nsCamera);
        UA_String_clear(&nsCameraUri);
    }

    if(nodeIds.find("ImagePNG") == nodeIds.end())
    {
        logger->error("ImagePNG NodeId not set");
        return UA_STATUSCODE_BADNOTFOUND;
    }

    UA_Variant v;
    UA_StatusCode ret = readVariable(UA_NODEID_NUMERIC(nsCamera, UA_CAMERAID_CAMERADEVICE_IMAGEPNG), &v);
    if (ret != UA_STATUSCODE_GOOD)
    {
        throw std::runtime_error("Cannot read node: " + std::string(UA_StatusCode_name(ret)));
    }
    if(v.type != &UA_TYPES[UA_TYPES_IMAGEPNG] && v.type != &UA_TYPES[UA_TYPES_BYTESTRING])
    {
        const char* typeName = v.type->typeName;
        UA_Variant_clear(&v);
        throw std::runtime_error("Cannot read image node. Is not of type ImagePNG but of type "
            + std::string(typeName));
    }

    logger->info("Read Image of TypeName: " + std::string(v.type->typeName));
    
    ret = UA_ImagePNG_copy((UA_ImagePNG*)v.data, image);

    UA_Variant_clear(&v);

    return ret;
}

UA_StatusCode CameraClient::readCameraInfoNode(UA_CameraInfoDataType* data)
{
    if(nodeIds.find("CameraInfo") == nodeIds.end())
    {
        logger->error("CameraInfo NodeId not set");
        return UA_STATUSCODE_BADNOTFOUND;
    }

    UA_StatusCode ret = UA_STATUSCODE_GOOD;

    UA_Variant v;
    UA_Variant_init(&v);
    {
        std::lock_guard<std::recursive_mutex> lk(clientMutex);
        // ret = pnp::opcua::UA_Client_readVariable(client, nodeIds["CamefaInfo"], &v);
        ret = UA_Client_readValueAttribute(client, nodeIds["CameraInfo"], &v);
    }

    if (ret != UA_STATUSCODE_GOOD)
    {
        logger->error("Cannot read camera info node: " + std::string(UA_StatusCode_name(ret)));
        return ret;
    }

    data = (UA_CameraInfoDataType*)v.data;

    return ret;
}

UA_StatusCode CameraClient::readCameraPoseNode(UA_PoseDataType* data)
{
    if(nodeIds.find("CameraPose") == nodeIds.end())
    {
        logger->error("CameraPose NodeId not set");
        return UA_STATUSCODE_BADNOTFOUND;
    }

    UA_StatusCode ret = UA_STATUSCODE_GOOD;

    return ret;
}

void CameraClient::threadWorker() 
{
    bool success = true;
    while (running && success) {
        success &= this->step(0);
        std::this_thread::sleep_for(std::chrono::milliseconds(1));
    }
    running = false;
}

UA_StatusCode CameraClient::addEventSubscription()
{
    std::lock_guard<std::recursive_mutex> lk(clientMutex);

    UA_CreateSubscriptionRequest subRequest = UA_CreateSubscriptionRequest_default();
    UA_CreateSubscriptionResponse subResponse = UA_Client_Subscriptions_create(client, subRequest,
                                                                               this, nullptr, nullptr);
    if (subResponse.responseHeader.serviceResult != UA_STATUSCODE_GOOD) {
        UA_Client_disconnect(client);
        UA_Client_delete(client);
        throw std::runtime_error(
                "Failed to create subscription, status code " +
                std::string(UA_StatusCode_name(subResponse.responseHeader.serviceResult)));
    }

    subId = subResponse.subscriptionId;

    UA_UInt16 nsCamera;

    {
        UA_String nsCameraUri = UA_String_fromChars(NAMESPACE_URI_CAMERA);
        UA_Client_NamespaceGetIndex(client, &nsCameraUri, &nsCamera);
        UA_String_clear(&nsCameraUri);
    }

    /* Add a MonitoredItem */
    UA_MonitoredItemCreateRequest item;
    UA_MonitoredItemCreateRequest_init(&item);
    item.itemToMonitor.nodeId = UA_NODEID_NUMERIC(nsCamera, UA_CAMERAID_CAMERADEVICE_SKILLS_PHOTOSKILL);
    item.itemToMonitor.attributeId = UA_ATTRIBUTEID_EVENTNOTIFIER;
    item.monitoringMode = UA_MONITORINGMODE_REPORTING;

    item.requestedParameters.filter.encoding = UA_EXTENSIONOBJECT_DECODED;
    UA_EventFilter filter;
    if (!getEventFilter(&filter)) {
        throw std::runtime_error("Cannot create event filter");
    }
    item.requestedParameters.filter.content.decoded.data = &filter;
    item.requestedParameters.filter.content.decoded.type = &UA_TYPES[UA_TYPES_EVENTFILTER];
    // set a minimum queue size of > 2 so that we get all the events, if the robot already reached the position and sends
    // two events at the same time.
    item.requestedParameters.queueSize = 20;
    item.requestedParameters.discardOldest = true;

    UA_MonitoredItemCreateResult result =
            UA_Client_MonitoredItems_createEvent(client, subId,
                                                 UA_TIMESTAMPSTORETURN_BOTH, item,
                                                 nullptr, &CameraClient::eventHandlerCallback, nullptr);

    if (result.statusCode != UA_STATUSCODE_GOOD) {
        logger->error("Failed to add MonitoredItem, status code {}", std::string(UA_StatusCode_name(result.statusCode)));
        UA_StatusCode ret = result.statusCode;
        UA_MonitoredItemCreateResult_clear(&result);
        UA_Array_delete(filter.selectClauses, filter.selectClausesSize, &UA_TYPES[UA_TYPES_SIMPLEATTRIBUTEOPERAND]);
        return ret;
    }

    monId = result.monitoredItemId;

    UA_MonitoredItemCreateResult_clear(&result);
    UA_Array_delete(filter.selectClauses, filter.selectClausesSize, &UA_TYPES[UA_TYPES_SIMPLEATTRIBUTEOPERAND]);
    return UA_STATUSCODE_GOOD;
}

#define EVENT_FILTER_SELECT_COUNT 8

bool CameraClient::getEventFilter(UA_EventFilter *filter) {
    UA_EventFilter_init(filter);

    auto *selectClauses = (UA_SimpleAttributeOperand *)
            UA_Array_new(EVENT_FILTER_SELECT_COUNT, &UA_TYPES[UA_TYPES_SIMPLEATTRIBUTEOPERAND]);
    if (!selectClauses)
        return false;

    for (size_t i = 0; i < EVENT_FILTER_SELECT_COUNT; ++i) {
        UA_SimpleAttributeOperand_init(&selectClauses[i]);
    }

    selectClauses[0].typeDefinitionId = UA_NODEID_NUMERIC(0, UA_NS0ID_PROGRAMTRANSITIONEVENTTYPE);
    selectClauses[0].browsePathSize = 1;
    selectClauses[0].browsePath = (UA_QualifiedName *)
            UA_Array_new(selectClauses[0].browsePathSize, &UA_TYPES[UA_TYPES_QUALIFIEDNAME]);
    if (!selectClauses[0].browsePath) {
        UA_SimpleAttributeOperand_clear(selectClauses);
        UA_SimpleAttributeOperand_delete(selectClauses);
        return false;
    }
    selectClauses[0].attributeId = UA_ATTRIBUTEID_VALUE;
    selectClauses[0].browsePath[0] = UA_QUALIFIEDNAME_ALLOC(0, "EventType");

    selectClauses[1].typeDefinitionId = UA_NODEID_NUMERIC(0, UA_NS0ID_PROGRAMTRANSITIONEVENTTYPE);
    selectClauses[1].browsePathSize = 1;
    selectClauses[1].browsePath = (UA_QualifiedName *)
            UA_Array_new(selectClauses[1].browsePathSize, &UA_TYPES[UA_TYPES_QUALIFIEDNAME]);
    if (!selectClauses[1].browsePath) {
        UA_SimpleAttributeOperand_clear(selectClauses);
        UA_SimpleAttributeOperand_delete(selectClauses);
        return false;
    }
    selectClauses[1].attributeId = UA_ATTRIBUTEID_VALUE;
    selectClauses[1].browsePath[0] = UA_QUALIFIEDNAME_ALLOC(0, "Severity");

    selectClauses[2].typeDefinitionId = UA_NODEID_NUMERIC(0, UA_NS0ID_PROGRAMTRANSITIONEVENTTYPE);
    selectClauses[2].browsePathSize = 1;
    selectClauses[2].browsePath = (UA_QualifiedName *)
            UA_Array_new(selectClauses[2].browsePathSize, &UA_TYPES[UA_TYPES_QUALIFIEDNAME]);
    if (!selectClauses[2].browsePath) {
        UA_SimpleAttributeOperand_delete(selectClauses);
        return false;
    }
    selectClauses[2].attributeId = UA_ATTRIBUTEID_VALUE;
    selectClauses[2].browsePath[0] = UA_QUALIFIEDNAME_ALLOC(0, "Message");

    selectClauses[3].typeDefinitionId = UA_NODEID_NUMERIC(0, UA_NS0ID_PROGRAMTRANSITIONEVENTTYPE);
    selectClauses[3].browsePathSize = 1;
    selectClauses[3].browsePath = (UA_QualifiedName *)
            UA_Array_new(selectClauses[3].browsePathSize, &UA_TYPES[UA_TYPES_QUALIFIEDNAME]);
    if (!selectClauses[3].browsePath) {
        UA_SimpleAttributeOperand_delete(selectClauses);
        return false;
    }
    selectClauses[3].attributeId = UA_ATTRIBUTEID_VALUE;
    selectClauses[3].browsePath[0] = UA_QUALIFIEDNAME_ALLOC(0, "FromState");

    selectClauses[4].typeDefinitionId = UA_NODEID_NUMERIC(0, UA_NS0ID_PROGRAMTRANSITIONEVENTTYPE);
    selectClauses[4].browsePathSize = 1;
    selectClauses[4].browsePath = (UA_QualifiedName *)
            UA_Array_new(selectClauses[4].browsePathSize, &UA_TYPES[UA_TYPES_QUALIFIEDNAME]);
    if (!selectClauses[4].browsePath) {
        UA_SimpleAttributeOperand_delete(selectClauses);
        return false;
    }
    selectClauses[4].attributeId = UA_ATTRIBUTEID_VALUE;
    selectClauses[4].browsePath[0] = UA_QUALIFIEDNAME_ALLOC(0, "ToState");

    selectClauses[5].typeDefinitionId = UA_NODEID_NUMERIC(0, UA_NS0ID_PROGRAMTRANSITIONEVENTTYPE);
    selectClauses[5].browsePathSize = 1;
    selectClauses[5].browsePath = (UA_QualifiedName *)
            UA_Array_new(selectClauses[5].browsePathSize, &UA_TYPES[UA_TYPES_QUALIFIEDNAME]);
    if (!selectClauses[5].browsePath) {
        UA_SimpleAttributeOperand_delete(selectClauses);
        return false;
    }
    selectClauses[5].attributeId = UA_ATTRIBUTEID_VALUE;
    selectClauses[5].browsePath[0] = UA_QUALIFIEDNAME_ALLOC(0, "Transition");

    selectClauses[6].typeDefinitionId = UA_NODEID_NUMERIC(0, UA_NS0ID_PROGRAMTRANSITIONEVENTTYPE);
    selectClauses[6].browsePathSize = 1;
    selectClauses[6].browsePath = (UA_QualifiedName *)
            UA_Array_new(selectClauses[6].browsePathSize, &UA_TYPES[UA_TYPES_QUALIFIEDNAME]);
    if (!selectClauses[6].browsePath) {
        UA_SimpleAttributeOperand_delete(selectClauses);
        return false;
    }
    selectClauses[6].attributeId = UA_ATTRIBUTEID_VALUE;
    selectClauses[6].browsePath[0] = UA_QUALIFIEDNAME_ALLOC(0, "IntermediateResult");


    selectClauses[7].typeDefinitionId = UA_NODEID_NUMERIC(0, UA_NS0ID_PROGRAMTRANSITIONEVENTTYPE);
    selectClauses[7].browsePathSize = 1;
    selectClauses[7].browsePath = (UA_QualifiedName *)
            UA_Array_new(selectClauses[7].browsePathSize, &UA_TYPES[UA_TYPES_QUALIFIEDNAME]);
    if (!selectClauses[7].browsePath) {
        UA_SimpleAttributeOperand_delete(selectClauses);
        return false;
    }
    selectClauses[7].attributeId = UA_ATTRIBUTEID_VALUE;
    selectClauses[7].browsePath[0] = UA_QUALIFIEDNAME_ALLOC(0, "Time");

    filter->selectClauses = selectClauses;
    filter->selectClausesSize = EVENT_FILTER_SELECT_COUNT;

    return true;
}

void CameraClient::eventHandlerCallback(UA_Client *client,
                                       UA_UInt32 subIdParam, void *subContext,
                                       UA_UInt32 monIdParam, void *monContext,
                                       size_t nEventFields, UA_Variant *eventFields) {
    if (!subContext)
        return;
    auto *self = static_cast<CameraClient *>(subContext);

    self->eventHandler(subIdParam, monIdParam, monContext, nEventFields, eventFields);
}


void CameraClient::eventHandler(UA_UInt32 subIdParam, UA_UInt32 monIdParam, void *monContext, size_t nEventFields,
                               UA_Variant *eventFields) {

    logger->info("Event handler!");
}