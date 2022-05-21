#include <CameraClient.h>

#include <camera_nodeids.h>
#include <skills/camera/PhotoSkill.hpp>

#include <open62541/client_highlevel.h>

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
        serverURL(serverURL), username(username), password(password)
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

void CameraClient::threadWorker() 
{
    bool success = true;
    while (running && success) {
        success &= this->step(0);
        std::this_thread::sleep_for(std::chrono::milliseconds(1));
    }
    running = false;
}