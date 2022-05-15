#ifndef PNP_SKILLS_SKILLHELPER_HPP
#define PNP_SKILLS_SKILLHELPER_HPP

#include <client/RegisteredSkill.h>
#include <client/SkillParameter.h>

namespace pnp {
    namespace skill {
        inline
        UA_StatusCode callSkillNoParameters(std::shared_ptr <RegisteredSkill> skill,
                                           std::shared_ptr <spdlog::logger>& loggerApp,
                                           std::shared_ptr <spdlog::logger>& loggerOpcua) {
            loggerApp->info("Executing skill {} on {}", skill->getSkillNameStr(),
                         skill->getParentComponent()->endpointUrl);

            std::vector <std::shared_ptr<SkillParameter>> parameters = std::vector < std::shared_ptr < SkillParameter >> ();
            parameters.reserve(0);

            UA_StatusCode result = UA_STATUSCODE_GOOD;
            std::chrono::steady_clock::time_point begin = std::chrono::steady_clock::now();
            bool success = false;
            try {
                success = skill->execute(loggerApp, loggerOpcua, parameters).get();
                if (!success) {
                    loggerApp->warn("Skill execution returned false. Probably there was an issue while running.");
                }
            } catch (pnp::opcua::StatusCodeException& ex) {
                loggerApp->error("Skill execution failed with error {}", UA_StatusCode_name(ex.get_code()));
                result = ex.get_code();
            }
            std::chrono::steady_clock::time_point end = std::chrono::steady_clock::now();

            loggerApp->info("Finished skill execution {} on {}.\n\tDuration: {} [ms]\n\tResult: {}\n\tSuccess: {}",
                         skill->getSkillNameStr(),
                         skill->getParentComponent()->endpointUrl,
                         std::chrono::duration_cast<std::chrono::milliseconds>(end - begin).count(),
                         UA_StatusCode_name(result), success);

            if (!success)
                return UA_STATUSCODE_BADINTERNALERROR;

            return result;
        }
    }
}

#endif