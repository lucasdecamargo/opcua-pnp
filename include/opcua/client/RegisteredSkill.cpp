#include <client/RegisteredSkill.h>

#include <open62541/client_highlevel.h>
#include <open62541/types_generated_handling.h>
#include <helper.hpp>

RegisteredSkill::RegisteredSkill(
        std::shared_ptr<RegisteredComponent>& parentComponent,
        std::shared_ptr<spdlog::logger>& logger,
        UA_NodeId& skillNodeId,
        const std::string& clientCertPath,
        const std::string& clientKeyPath,
        const std::string& clientAppUri,
        const std::string& clientAppName) :
        parentComponent(parentComponent),
        clientCertPath(clientCertPath),
        clientKeyPath(clientKeyPath),
        clientAppUri(clientAppUri),
        clientAppName(clientAppName) {

    UA_StatusCode retval;
    {
        LockedClient lc = parentComponent->getLockedClient();
        retval = UA_Client_readBrowseNameAttribute(lc.get(), skillNodeId, &browseName);
    }
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cannot read browse name attribute of skill node. Error {}", UA_StatusCode_name(retval));
        throw pnp::opcua::StatusCodeException(retval);
    }

    retval = UA_NodeId_copy(&skillNodeId, &this->skillNodeId);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cannot node id. Error {}", UA_StatusCode_name(retval));
        throw pnp::opcua::StatusCodeException(retval);
    }

    UA_BrowseRequest bReq;
    UA_BrowseRequest_init(&bReq);
    bReq.requestedMaxReferencesPerNode = 0;
    bReq.nodesToBrowse = UA_BrowseDescription_new();
    bReq.nodesToBrowseSize = 1;
    UA_NodeId_copy(&skillNodeId, &(bReq.nodesToBrowse[0].nodeId));
    bReq.nodesToBrowse[0].resultMask = UA_BROWSERESULTMASK_ALL; /* return everything */
    UA_BrowseResponse bResp;
    {
        LockedClient lc = parentComponent->getLockedClient();
        bResp = UA_Client_Service_browse(lc.get(), bReq);
    }

    if (bResp.responseHeader.serviceResult != UA_STATUSCODE_GOOD) {
        logger->error("Can not browse server for children. Error {}",
                      UA_StatusCode_name(bResp.responseHeader.serviceResult));
        UA_BrowseRequest_clear(&bReq);
        UA_BrowseResponse_clear(&bResp);
        throw pnp::opcua::StatusCodeException(bResp.responseHeader.serviceResult);
    } else {
        for (size_t i = 0; i < bResp.resultsSize; ++i) {
            for (size_t j = 0; j < bResp.results[i].referencesSize; ++j) {
                UA_ReferenceDescription *ref = &(bResp.results[i].references[j]);

                UA_NodeId hasTypeDefinition = UA_NODEID_NUMERIC(0, UA_NS0ID_HASTYPEDEFINITION);
                if (UA_NodeId_equal(&ref->referenceTypeId, &hasTypeDefinition)) {
                    UA_NodeId_copy(&ref->nodeId.nodeId, &skillTypeId);
                }
            }
        }
    }

    UA_BrowseRequest_clear(&bReq);
    UA_BrowseResponse_clear(&bResp);


    {
        LockedClient lc = parentComponent->getLockedClient();
        retval = UA_Client_readBrowseNameAttribute(lc.get(), skillNodeId, &skillTypeName);
    }
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cannot read browse name attribute of skill type node. Error {}", UA_StatusCode_name(retval));
        throw pnp::opcua::StatusCodeException(retval);
    }
}

RegisteredSkill::~RegisteredSkill() {
    UA_QualifiedName_clear(&browseName);

    if (skillClient) {
        delete skillClient;
    }
}

std::future<bool> RegisteredSkill::execute(
        std::shared_ptr<spdlog::logger>& loggerApp,
        std::shared_ptr<spdlog::logger>& loggerOpcua,
        const std::vector<std::shared_ptr<SkillParameter>>& parameters) {

    if (!skillClient) {
        UA_Client *uaClient = pnp::opcua::UA_Helper_getClientForEndpoint(
                this->parentComponent->endpoint.get(),
                loggerOpcua,
                clientCertPath,
                clientKeyPath,
                clientAppUri,
                clientAppName
        );

        skillClient = new GenericSkillClient(loggerApp, loggerOpcua, this->parentComponent->endpointUrl, this->skillNodeId, uaClient, "", "", false);
    }

    std::promise<bool> promiseMoveFinished;
    // ensure thread is running. If already running, this will do nothing
    UA_StatusCode ret = skillClient->runThreaded();
    if (ret != UA_STATUSCODE_GOOD && ret != UA_STATUSCODE_BADALREADYEXISTS) {
        return pnp::opcua::setPromiseErrorException<bool>(&promiseMoveFinished, ret);
    }
    // ensure client is connected. If already connected, this will do nothing
    ret = skillClient->connect();
    if (ret != UA_STATUSCODE_GOOD) {
        return pnp::opcua::setPromiseErrorException<bool>(&promiseMoveFinished, ret);
    }

    for (const auto& p: parameters) {
        UA_StatusCode code = skillClient->setParameterValue(p->getBrowseName(), p->getValue());
        if (code != UA_STATUSCODE_GOOD) {
            loggerApp->error("Could not set parameter {}: {}", p->getBrowseName(), UA_StatusCode_name(code));
            skillClient->stopThreaded();
            return pnp::opcua::setPromiseErrorException<bool>(&promiseMoveFinished, code);
        }
    }

    UA_StatusCode retval = skillClient->writeParameterSet();
    if (retval != UA_STATUSCODE_GOOD) {
        loggerApp->error("Could not write parameter set. {}", UA_StatusCode_name(retval));
        skillClient->stopThreaded();
        return pnp::opcua::setPromiseErrorException<bool>(&promiseMoveFinished, retval);
    }

    skillClient->emptyReceivedStates();
    retval = skillClient->start();
    if (retval != UA_STATUSCODE_GOOD) {
        loggerApp->error("Could not call start. {}", UA_StatusCode_name(retval));
        skillClient->stopThreaded();
        return pnp::opcua::setPromiseErrorException<bool>(&promiseMoveFinished, retval);
    }
    return std::async([this, loggerApp]() {
        pnp::opcua::ProgramStateNumber newState = skillClient->getNextState().get();
        if (newState != pnp::opcua::ProgramStateNumber::RUNNING) {
            loggerApp->error("Did not change to expected Running state.");
            skillClient->stopThreaded();
            throw pnp::opcua::StatusCodeException(UA_STATUSCODE_BADINVALIDSTATE);
        }
        newState = skillClient->getNextState().get();
        if (newState != pnp::opcua::ProgramStateNumber::READY) {
            loggerApp->error("Did not change to expected READY state. Resetting skill and returning error.");
            skillClient->resetWait().wait();
            skillClient->stopThreaded();
            return false;
        }
        skillClient->stopThreaded();
        return true;
    });
}

std::future<UA_StatusCode> RegisteredSkill::getFinalResultData(std::shared_ptr<spdlog::logger>& logger, const UA_String& resultData, UA_Variant *data) {
    if (!skillClient) {
        std::promise<UA_StatusCode> promiseMoveFinished;
        logger->error("Can not call getFinalResultData if skillClient is null. Call execute first");
        return pnp::opcua::setPromiseErrorException<UA_StatusCode>(&promiseMoveFinished, UA_STATUSCODE_BADINVALIDSTATE);
    }
    return skillClient->getFinalResultData(resultData, data, true);
}
