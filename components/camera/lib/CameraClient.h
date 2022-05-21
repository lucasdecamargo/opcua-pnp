#ifndef PNP_CAMERA_CLIENT_H
#define PNP_CAMERA_CLIENT_H

#include <memory>

#include <helper.hpp>

class CameraClient
{
public:
    explicit CameraClient(std::shared_ptr<spdlog::logger> _loggerApp,
                          std::shared_ptr<spdlog::logger> _loggerOpcua,
                          const std::string &serverURL,
                          const std::string &username = "",
                          const std::string &password = "",
                          const std::string& clientCertPath = "",
                          const std::string& clientKeyPath = "",
                          const std::string& clientAppUri = "",
                          const std::string& clientAppName = "");

    virtual ~CameraClient();

    UA_StatusCode connect();
    UA_StatusCode disconnect();
    bool step(UA_UInt16 timeout);
    UA_StatusCode stepAsync();
    void stop();

    UA_StatusCode readVariable(const UA_NodeId& node, UA_Variant* data);
    UA_StatusCode readImageNode(UA_ImagePNG* image);

protected:
    UA_Client *client;
    std::recursive_mutex clientMutex;
    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;

private:
    void threadWorker();

    std::string serverURL;
    std::string username;
    std::string password;

    bool running;
    std::thread stepperThread;
};

#endif