#ifndef OPCUA_CLIENT_SKILLPARAMETER_H
#define OPCUA_CLIENT_SKILLPARAMETER_H

#include <string>
#include <map>
#include <utility>
#include <spdlog/logger.h>
#include <open62541/types.h>

class SkillParameter {

protected:
    const std::string browseName;
    const std::string typeDefinition;
    const std::string dataType;

    UA_Variant value;

public:
    explicit SkillParameter(
            std::string  browseName,
            std::string typeDefinition,
            std::string dataType);
    virtual ~SkillParameter();

    const std::string& getBrowseName() {
        return browseName;
    }

    const UA_Variant& getValue() {
        return value;
    }

    UA_StatusCode setValue(const UA_Variant &var);

};

#endif