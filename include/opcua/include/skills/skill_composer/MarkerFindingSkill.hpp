#ifndef OPCUA_SKILLS_COMPOSED_MARKER_FINDING_SKILL_H
#define OPCUA_SKILLS_COMPOSED_MARKER_FINDING_SKILL_H

#include <SkillBase.hpp>
#include <functional>
#include <vector>

#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

#define NAMESPACE_URI_SKILLCOMPOSER "https://pnp.org/UA/SkillComposer/"

namespace pnp{
    namespace opcua{
        namespace skill{
            namespace skill_composer{
                class MarkerFindingSkill;

                class MarkerFindingSkillImpl : virtual public SkillImpl
                {
                public:
                    friend class MarkerFindingSkill;

                protected:
                    virtual bool start(std::vector<UA_MarkerDataType>& foundMarkers) = 0;
                    virtual bool halt() = 0;
                    virtual bool resume() = 0;
                    virtual bool suspend() = 0;
                    virtual bool reset() = 0;

                    std::function<void()> findingFinished;
                    std::function<void()> findingErrored;
                };


                class MarkerFindingSkill : virtual public SkillBase
                {
                protected:
                    const size_t nsDiIdx;
                    const size_t nsSkillComposerId;

                    const std::shared_ptr<UA_NodeId> parameterSetNodeId;

                    SkillParameter<std::vector<UA_MarkerDataType>> paramFoundMarkers;

                    UA_StatusCode readParameters() override
                    {
                        return UA_STATUSCODE_GOOD;
                    }
                
                public:
                    explicit MarkerFindingSkill(
                        const std::shared_ptr<pnp::opcua::OpcUaServer> &server,
                        std::shared_ptr<spdlog::logger> &logger,
                        const UA_NodeId &skillNodeId,
                        const std::string &eventSourceName
                    )
                        : SkillBase(server, logger, skillNodeId, eventSourceName),
                        nsDiIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_DI)),
                        nsSkillComposerId(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_SKILLCOMPOSER)),
                        parameterSetNodeId(UA_Server_getObjectComponentId(server, stateMachineNodeId,
                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                             const_cast<char*>("ParameterSet")))),
                        paramFoundMarkers(&UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_MARKERDATATYPE],
                                        "FoundMarkersArray",
                                        UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                            UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsSkillComposerId),
                                            const_cast<char*>("FoundMarkersArray"))))
                    {
                        auto selfProgram = dynamic_cast<Program*>(this);

                        LockedServer ls = server->getLocked();
                        if (UA_Server_setNodeContext(ls.get(), skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                            throw std::runtime_error("Adding method context failed");
                        }
                    }

                    virtual void setImpl(
                        MarkerFindingSkillImpl *impl,
                        std::function<void()> implDeleter = nullptr
                    )
                    {
                        SkillBase::setImpl(impl, std::move(implDeleter));

                        this->startCallback = [impl, this]() {
                            if (this->readParameters() != UA_STATUSCODE_GOOD)
                                return false;
                            
                            this->paramFoundMarkers.value.clear();
                                                        
                            return impl->start(this->paramFoundMarkers.value);
                        };
                        this->haltCallback = std::bind(
                                &MarkerFindingSkillImpl::halt, impl);
                        this->resumeCallback = std::bind(
                                &MarkerFindingSkillImpl::resume, impl);
                        this->suspendCallback = std::bind(
                                &MarkerFindingSkillImpl::suspend, impl);
                        this->resetCallback = std::bind(
                                &MarkerFindingSkillImpl::reset, impl);
                                
                        impl->findingErrored = std::bind(
                                &MarkerFindingSkill::findingErrored, this);
                        impl->findingFinished = std::bind(
                                &MarkerFindingSkill::findingFinished, this);
                    }

                    void findingFinished()
                    { 
                        updateParameters();

                        logger->trace("Making transition to READY");
                        if (!transition(ProgramStateNumber::READY)) {
                            logger->error("Failed to make transition after camera has finished to ready");
                        }
                        logger->trace("Transition successfull");
                    }

                    void findingErrored()
                    {
                        if (!transition(ProgramStateNumber::HALTED)) {
                            logger->error("Failed to make transition after camera has finished to halted");
                        }

                        if (!transition(ProgramStateNumber::READY)) {
                            logger->error("Failed to make transition back to ready");
                        }
                    }

                    void updateParameters()
                    {
                        logger->trace("Updating parameters");

                        UA_StatusCode ret;

                        UA_Variant v;
                        UA_Variant_init(&v);

                        UA_MarkerListDataType m_list;
                        m_list.markers = NULL;
                        m_list.markersSize = 0;

                        if(paramFoundMarkers.value.size() > 0)
                        {
                            m_list.markersSize = paramFoundMarkers.value.size();
                            m_list.markers = paramFoundMarkers.value.data();
                        }

                        UA_Variant_setScalar(&v, &m_list, &UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_MARKERLISTDATATYPE]);

                        {
                            LockedServer ls = server->getLocked();
                            ret = UA_Server_writeValue(ls.get(), *paramFoundMarkers.nodeId.get(), v);
                        }

                        paramFoundMarkers.value.clear();

                        if(ret != UA_STATUSCODE_GOOD) {
                            logger->error("Failed to write Detected Markers. Returned: " +
                                std::string(UA_StatusCode_name(ret)));
                        }

                    }
                };
            }
        }
    }
}

#endif
