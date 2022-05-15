#ifndef OPCUA_SKILLS_SKILLIMPL_HPP
#define OPCUA_SKILLS_SKILLIMPL_HPP

#include <SkillRunMutex.hpp>
#include <vector>

namespace pnp {

    namespace opcua {
        namespace skill {

            class SkillImpl {

            private:

                std::vector<SkillRunMutex*> runMutex;

            public:
                explicit SkillImpl() : runMutex() {

                }

                void addRunMutex(SkillRunMutex* mutex) {
                    runMutex.push_back(mutex);
                }
            };
        }
    }
}

#endif
