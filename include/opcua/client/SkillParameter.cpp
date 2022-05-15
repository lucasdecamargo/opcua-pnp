#include <client/SkillParameter.h>

#include <open62541/types_generated.h>
#include <regex>
#include <utility>
#include <open62541/types_generated_handling.h>

SkillParameter::SkillParameter(
        std::string browseName,
        std::string typeDefinition,
        std::string dataType):
        browseName(std::move(browseName)), typeDefinition(std::move(typeDefinition)), dataType(std::move(dataType)), value() {
    UA_Variant_init(&value);
}

SkillParameter::~SkillParameter() {
    UA_Variant_clear(&value);
}

UA_StatusCode SkillParameter::setValue(const UA_Variant &var) {
    return UA_Variant_copy(&var, &value);
}
