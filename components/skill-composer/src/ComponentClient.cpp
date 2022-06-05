#include <ComponentClient.h>

const UA_DataTypeArray ComponentClient::customDataTypes = {NULL, UA_TYPES_PNP_TYPES_COUNT, UA_TYPES_PNP_TYPES};

ComponentClient::ComponentClient(std::shared_ptr<spdlog::logger> logger,
                const std::shared_ptr<RegisteredSkill> skill) :
    logger(logger), skill(skill)
{

}

ComponentClient::~ComponentClient()
{

}


bool ComponentClient::connect()
{
    LockedClient lc = skill->getParentComponent()->getLockedClient();
    UA_Client_getConfig(client.get())->customDataTypes = &customDataTypes;

    return skill->getParentComponent()->connectClient();
}

void ComponentClient::disconnect()
{
    return skill->getParentComponent()->disconnectClient();
}


CameraClient::CameraClient(std::shared_ptr<spdlog::logger> logger,
                const std::shared_ptr<RegisteredSkill> skill) :
    ComponentClient(logger,skill)
{

}

