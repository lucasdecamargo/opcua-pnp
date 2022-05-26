#include <open62541/client.h>
#include <open62541/client_config_default.h>
#include <open62541/client_subscriptions.h>
#include <open62541/plugin/log_stdout.h>
#include <open62541/util.h>

#include <signal.h>

#include <string>

#define SKILL_NS 5
#define SKILL_NODEID 15211
#define EVENT_FILTER_SELECT_COUNT 8

static UA_Boolean running = true;

static void
handler_events_filter(UA_Client *client, UA_UInt32 subId, void *subContext,
                      UA_UInt32 monId, void *monContext,
                      size_t nEventFields, UA_Variant *eventFields) {
    UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_USERLAND, "Received Event Notification (Filter passed)");
    for(size_t i = 0; i < nEventFields; ++i) {
        if(UA_Variant_hasScalarType(&eventFields[i], &UA_TYPES[UA_TYPES_UINT16])) {
            UA_UInt16 severity = *(UA_UInt16 *)eventFields[i].data;
            UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_USERLAND, "Severity: %u", severity);
        } else if (UA_Variant_hasScalarType(&eventFields[i], &UA_TYPES[UA_TYPES_LOCALIZEDTEXT])) {
            UA_LocalizedText *lt = (UA_LocalizedText *)eventFields[i].data;
            UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_USERLAND,
                        "Message: '%.*s'", (int)lt->text.length, lt->text.data);
        } else if (UA_Variant_hasScalarType(&eventFields[i], &UA_TYPES[UA_TYPES_NODEID])) {
            UA_String nodeIdName = UA_STRING_ALLOC("");
            UA_NodeId_print((UA_NodeId *)eventFields[i].data, &nodeIdName);
            UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_USERLAND,
                        "TypeNodeId: '%.*s'", (int)nodeIdName.length, nodeIdName.data);
            UA_String_clear(&nodeIdName);
        } else {
#ifdef UA_ENABLE_TYPEDESCRIPTION
            UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_USERLAND,
                        "Don't know how to handle type: '%s'", eventFields[i].type->typeName);
#else
            UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_USERLAND,
                        "Don't know how to handle type, enable UA_ENABLE_TYPEDESCRIPTION "
                        "for typename");
#endif
        }
    }
}

static UA_SimpleAttributeOperand *
setupSelectClauses(size_t selectedFieldsSize, UA_QualifiedName *qName) {
    UA_SimpleAttributeOperand *selectClauses = (UA_SimpleAttributeOperand*)
        UA_Array_new(selectedFieldsSize, &UA_TYPES[UA_TYPES_SIMPLEATTRIBUTEOPERAND]);
    if(!selectClauses)
        return NULL;
    for(size_t i =0; i<selectedFieldsSize; ++i) {
        UA_SimpleAttributeOperand_init(&selectClauses[i]);
    }

    for (size_t i = 0; i < selectedFieldsSize; ++i) {
        selectClauses[i].typeDefinitionId = UA_NODEID_NUMERIC(0, UA_NS0ID_BASEEVENTTYPE);
        selectClauses[i].browsePathSize = 1;
        selectClauses[i].browsePath = (UA_QualifiedName*)
                UA_Array_new(selectClauses[i].browsePathSize, &UA_TYPES[UA_TYPES_QUALIFIEDNAME]);
        if(!selectClauses[i].browsePath) {
            UA_SimpleAttributeOperand_delete(selectClauses);
            return NULL;
        }
        selectClauses[i].attributeId = UA_ATTRIBUTEID_VALUE;
        char fieldName[64];
        memcpy(fieldName, qName[i].name.data, qName[i].name.length);
        fieldName[qName[i].name.length] = '\0';
        selectClauses[i].browsePath[0] = UA_QUALIFIEDNAME_ALLOC(0, fieldName);
    }
    return selectClauses;
}

void setupOfTypeFilter(UA_ContentFilterElement *element, UA_UInt16 nsIndex, UA_UInt32 typeId){
    element->filterOperands[0].content.decoded.type = &UA_TYPES[UA_TYPES_LITERALOPERAND];
    element->filterOperands[0].encoding = UA_EXTENSIONOBJECT_DECODED;
    UA_LiteralOperand *literalOperand = UA_LiteralOperand_new();
    UA_LiteralOperand_init(literalOperand);
    UA_NodeId *nodeId = UA_NodeId_new();
    UA_NodeId_init(nodeId);
    nodeId->namespaceIndex = nsIndex;
    nodeId->identifierType = UA_NODEIDTYPE_NUMERIC;
    nodeId->identifier.numeric = typeId;
    UA_Variant_setScalar(&literalOperand->value, nodeId, &UA_TYPES[UA_TYPES_NODEID]);
    element->filterOperands[0].content.decoded.data = literalOperand;
}

UA_StatusCode setupOperandArrays(UA_ContentFilter *contentFilter){
    for(size_t i =0; i< contentFilter->elementsSize; ++i) {  /* Set Operands Arrays */
        contentFilter->elements[i].filterOperands = (UA_ExtensionObject*)
            UA_Array_new(
                contentFilter->elements[i].filterOperandsSize, &UA_TYPES[UA_TYPES_EXTENSIONOBJECT]);
        if (!contentFilter->elements[i].filterOperands){
            UA_ContentFilter_clear(contentFilter);
            return UA_STATUSCODE_BADOUTOFMEMORY;
        }
        for(size_t n =0; n< contentFilter->elements[i].filterOperandsSize; ++n) {
            UA_ExtensionObject_init(&contentFilter->elements[i].filterOperands[n]);
        }
    }
    return UA_STATUSCODE_GOOD;
}

UA_StatusCode setupWhereClause(UA_ContentFilter *contentFilter)
{
    UA_ContentFilter_init(contentFilter);
    contentFilter->elementsSize = 1;
    contentFilter->elements = (UA_ContentFilterElement *)UA_new(&UA_TYPES[UA_TYPES_CONTENTFILTERELEMENT]);

    if(!contentFilter->elements)
        return UA_STATUSCODE_BADOUTOFMEMORY;

    UA_ContentFilterElement_init(contentFilter->elements);

    contentFilter->elements->filterOperator = UA_FILTEROPERATOR_OFTYPE;
    contentFilter->elements->filterOperandsSize = 1;

    if(setupOperandArrays(contentFilter) != UA_STATUSCODE_GOOD) {
        UA_ContentFilter_clear(contentFilter);
        return UA_STATUSCODE_BADCONFIGURATIONERROR;
    }

    setupOfTypeFilter(contentFilter->elements, 0, UA_NS0ID_PROGRAMTRANSITIONEVENTTYPE);

    return UA_STATUSCODE_GOOD;
}

bool getEventFilter(UA_EventFilter *filter) {
    UA_EventFilter_init(filter);

    UA_QualifiedName qm[EVENT_FILTER_SELECT_COUNT];
    qm[0].namespaceIndex = 0;
    qm[0].name = UA_String_fromChars("EventType");
    qm[1].namespaceIndex = 0;
    qm[1].name = UA_String_fromChars("Severity");
    qm[2].namespaceIndex = 0;
    qm[2].name = UA_String_fromChars("Message");
    qm[3].namespaceIndex = 0;
    qm[3].name = UA_String_fromChars("FromState");
    qm[4].namespaceIndex = 0;
    qm[4].name = UA_String_fromChars("ToState");
    qm[5].namespaceIndex = 0;
    qm[5].name = UA_String_fromChars("Transition");
    qm[6].namespaceIndex = 0;
    qm[6].name = UA_String_fromChars("IntermediateResult");
    qm[7].namespaceIndex = 0;
    qm[7].name = UA_String_fromChars("Time");

    filter->selectClauses = setupSelectClauses(EVENT_FILTER_SELECT_COUNT, qm);
    filter->selectClausesSize = EVENT_FILTER_SELECT_COUNT;
    setupWhereClause(&filter->whereClause);

    return true;
}

UA_StatusCode addEventSubscription(UA_Client *client)
{
    /* Create a subscription */
    UA_CreateSubscriptionRequest subRequest = UA_CreateSubscriptionRequest_default();
    UA_CreateSubscriptionResponse subResponse = UA_Client_Subscriptions_create(client, subRequest,
                                                                               nullptr, nullptr, nullptr);
    if (subResponse.responseHeader.serviceResult != UA_STATUSCODE_GOOD) {
        UA_Client_disconnect(client);
        UA_Client_delete(client);
        return EXIT_FAILURE;
    }

    UA_UInt32 subId = subResponse.subscriptionId;
    UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_USERLAND, "Create subscription succeeded, id %u", subId);

    /* Add a MonitoredItem */
    UA_MonitoredItemCreateRequest item;
    UA_MonitoredItemCreateRequest_init(&item);
    item.itemToMonitor.nodeId = UA_NODEID_NUMERIC(SKILL_NS, SKILL_NODEID);
    item.itemToMonitor.attributeId = UA_ATTRIBUTEID_EVENTNOTIFIER;
    item.monitoringMode = UA_MONITORINGMODE_REPORTING;

    item.requestedParameters.filter.encoding = UA_EXTENSIONOBJECT_DECODED;
    UA_EventFilter filter;
    if (!getEventFilter(&filter)) {
        return EXIT_FAILURE;
    }
    item.requestedParameters.filter.content.decoded.data = &filter;
    item.requestedParameters.filter.content.decoded.type = &UA_TYPES[UA_TYPES_EVENTFILTER];
    // set a minimum queue size of > 2 so that we get all the events, if the robot already reached the position and sends
    // two events at the same time.
    item.requestedParameters.queueSize = 20;
    item.requestedParameters.discardOldest = true;

    UA_UInt32 monId = 0;
    UA_MonitoredItemCreateResult result =
            UA_Client_MonitoredItems_createEvent(client, subId,
                                                 UA_TIMESTAMPSTORETURN_BOTH, item,
                                                 &monId, handler_events_filter, nullptr);

    if (result.statusCode != UA_STATUSCODE_GOOD) {
        UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_USERLAND,
                    "Could not add the MonitoredItem with %s", UA_StatusCode_name(result.statusCode));
        UA_StatusCode ret = result.statusCode;
        UA_MonitoredItemCreateResult_clear(&result);
        UA_Array_delete(filter.selectClauses, filter.selectClausesSize, &UA_TYPES[UA_TYPES_SIMPLEATTRIBUTEOPERAND]);
        UA_Array_delete(filter.whereClause.elements, filter.whereClause.elementsSize, &UA_TYPES[UA_TYPES_CONTENTFILTERELEMENT]);
        return ret;
    }
    else {
        UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_USERLAND,
                    "Monitoring 'Root->Objects->Server', id %u", subResponse.subscriptionId);
    }

    while(running)
        UA_Client_run_iterate(client, 100);

    UA_MonitoredItemCreateResult_clear(&result);
    UA_Array_delete(filter.selectClauses, filter.selectClausesSize, &UA_TYPES[UA_TYPES_SIMPLEATTRIBUTEOPERAND]);
    UA_Array_delete(filter.whereClause.elements, filter.whereClause.elementsSize, &UA_TYPES[UA_TYPES_CONTENTFILTERELEMENT]);
    return UA_STATUSCODE_GOOD;
}

static void stopHandler(int sig) {
    UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_USERLAND, "received ctrl-c");
    running = false;
}

int main(int argc, char *argv[]) 
{
    signal(SIGINT, stopHandler);
    signal(SIGTERM, stopHandler);

    if(argc < 2) {
        printf("Usage: tutorial_client_event_filter <opc.tcp://server-url>\n");
        return EXIT_FAILURE;
    }

    UA_Client *client = UA_Client_new();
    UA_ClientConfig_setDefault(UA_Client_getConfig(client));

    UA_StatusCode retval = UA_Client_connect(client, argv[1]);
    if(retval != UA_STATUSCODE_GOOD) {
        UA_Client_delete(client);
        return EXIT_FAILURE;
    }

    retval = addEventSubscription(client);

    UA_Client_disconnect(client);
    UA_Client_delete(client);

    return retval == UA_STATUSCODE_GOOD ? EXIT_SUCCESS : EXIT_FAILURE;
}