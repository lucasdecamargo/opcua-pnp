cmake_minimum_required(VERSION 3.0.0)

get_directory_property(hasParent PARENT_DIRECTORY)
if(hasParent)
    project(${PROJECT_NAME}-opcua)
else()
    # opcua is built standalone
    project(opcua)
endif()

find_package(open62541 1.2 REQUIRED COMPONENTS FullNamespace Events)

set(OPCUA_DIR "${CMAKE_CURRENT_LIST_DIR}")
get_directory_property(hasParent PARENT_DIRECTORY)
if(hasParent)
    set(OPCUA_DIR "${CMAKE_CURRENT_LIST_DIR}" PARENT_SCOPE)
endif()

set(CMAKE_MODULE_PATH ${CMAKE_MODULE_PATH} ${CMAKE_CURRENT_LIST_DIR}/cmake)

set(GENERATE_OUTPUT_DIR "${CMAKE_BINARY_DIR}/src_generated/${PROJECT_NAME}-client")
file(MAKE_DIRECTORY "${GENERATE_OUTPUT_DIR}")
include_directories("${GENERATE_OUTPUT_DIR}")

ua_generate_nodeset_and_datatypes(
        NAME "di"
        TARGET_PREFIX "${PROJECT_NAME}"
        FILE_CSV "${open62541_NODESET_DIR}/DI/OpcUaDiModel.csv"
        FILE_BSD "${open62541_NODESET_DIR}/DI/Opc.Ua.Di.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "2:http://opcfoundation.org/UA/DI/"
        FILE_NS "${open62541_NODESET_DIR}/DI/Opc.Ua.Di.NodeSet2.xml"
        INTERNAL
)

ua_generate_nodeset_and_datatypes(
        NAME "device_model"
        TARGET_PREFIX "${PROJECT_NAME}"
        FILE_CSV "${CMAKE_CURRENT_LIST_DIR}/../../nodeset/DeviceModel/Published/DeviceModel/DeviceModel.csv"
        FILE_BSD "${CMAKE_CURRENT_LIST_DIR}/../../nodeset/DeviceModel/Published/DeviceModel/fortiss_Device.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "3:https://fortiss.org/UA/Device/"
        FILE_NS "${CMAKE_CURRENT_LIST_DIR}/../../nodeset/DeviceModel/Published/DeviceModel/fortiss_Device.NodeSet2.xml"
        DEPENDS "di"
        INTERNAL
)

ua_generate_nodeset_and_datatypes(
        NAME "pnp_types"
        TARGET_PREFIX "${PROJECT_NAME}"
        FILE_CSV "${CMAKE_CURRENT_LIST_DIR}/../../nodeset/PnPTypes/Published/PnPTypes/PnPTypes.csv"
        FILE_BSD "${CMAKE_CURRENT_LIST_DIR}/../../nodeset/PnPTypes/Published/PnPTypes/PnPTypes.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "4:https://pnp.org/UA/PnPTypes/"
        FILE_NS "${CMAKE_CURRENT_LIST_DIR}/../../nodeset/PnPTypes/Published/PnPTypes/PnPTypes.NodeSet2.xml"
        DEPENDS "device_model" "di"
        INTERNAL
)


add_library(${PROJECT_NAME}
    server/OpcUaServer.cpp
    include/skills/camera/PhotoSkill.hpp
    include/skills/camera/ImageSkill.hpp
    include/skills/camera/ImageFrameSkill.hpp
    include/skills/camera/ImageStreamSkill.hpp
    include/skills/image_processing/MarkerDetectionSkill.hpp
    include/skills/image_processor/MarkerDetectionSkill.hpp
    include/skills/composed/RTMarkerDetectionSkill.hpp
    ${UA_NODESET_DI_SOURCES}
    ${UA_TYPES_DI_SOURCES}
    ${UA_NODESET_DEVICE_MODEL_SOURCES}
    ${UA_TYPES_DEVICE_MODEL_SOURCES}
    ${UA_NODESET_PNP_TYPES_SOURCES}
    ${UA_TYPES_PNP_TYPES_SOURCES}
)

target_include_directories(${PROJECT_NAME} PUBLIC
    include
    include/spdlog/include
    $<TARGET_PROPERTY:open62541::open62541,INTERFACE_INCLUDE_DIRECTORIES>
    ${GENERATE_OUTPUT_DIR}
)

target_link_libraries(${PROJECT_NAME}
    open62541::open62541
    config++
    pthread
)

add_dependencies(${PROJECT_NAME}
    # open62541::open62541
    ${PROJECT_NAME}-ns-di
    ${PROJECT_NAME}-ns-device_model
    ${PROJECT_NAME}-ns-pnp_types
)

add_library(${PROJECT_NAME}-client
    client/GenericSkillClient.cpp
    client/SkillClient.cpp
    client/SkillClientParameter.cpp
    client/RegisteredComponent.cpp
    client/RegisteredSkill.cpp
    client/SkillParameter.cpp
    client/SkillDetector.cpp
    include/client/SkillHelper.hpp
)

target_include_directories(${PROJECT_NAME}-client PUBLIC
    include
    include/spdlog/include
    $<TARGET_PROPERTY:open62541::open62541,INTERFACE_INCLUDE_DIRECTORIES>
)

target_link_libraries(${PROJECT_NAME}-client
    open62541::open62541
    config++
    pthread
)

add_dependencies(${PROJECT_NAME}-client
    ${PROJECT_NAME}
    ${PROJECT_NAME}-ns-di
    ${PROJECT_NAME}-ns-device_model
)

function(generate_certificate)
    set(options  )
    set(oneValueArgs TARGET_NAME HOSTNAME APP_URI OUTPUT_DIR)
    set(multiValueArgs )
    cmake_parse_arguments(GEN_CERT "${options}" "${oneValueArgs}" "${multiValueArgs}" ${ARGN} )
    
    if(NOT GEN_CERT_APP_URI OR "${GEN_CERT_APP_URI}" STREQUAL "")
        message(FATAL_ERROR "generate_certificate function requires a value for the APP_URI argument")
    endif()
    if(NOT GEN_CERT_OUTPUT_DIR OR "${GEN_CERT_OUTPUT_DIR}" STREQUAL "")
        message(FATAL_ERROR "generate_certificate function requires a value for the OUTPUT_DIR argument")
    endif()
    if(NOT GEN_CERT_TARGET_NAME OR "${GEN_CERT_TARGET_NAME}" STREQUAL "")
        message(FATAL_ERROR "generate_certificate function requires a value for the TARGET_NAME argument")
    endif()

    message("Generating certificate for ${GEN_CERT_APP_URI} - ${PYTHON_EXECUTABLE}")

    if (GEN_CERT_HOSTNAME)
        set(HOSTNAME "${GEN_CERT_HOSTNAME}")
    else()
        if (CUSTOM_HOSTNAME)
            set(HOSTNAME "${CUSTOM_HOSTNAME}")
        else()
            cmake_host_system_information(RESULT HOSTNAME QUERY HOSTNAME)
        endif()
    endif()

    # add_custom_command(OUTPUT ${GEN_CERT_TARGET_NAME}
    #                    ${GEN_CERT_OUTPUT_DIR}/${HOSTNAME}_key.der
    #                    PRE_BUILD
    #                    COMMAND ${PYTHON_EXECUTABLE} ${OPCUA_DIR}/tools/create_self-signed.py
    #                    --application-uri=${GEN_CERT_APP_URI}
    #                    --key=4096
    #                    --hostname=${HOSTNAME}
    #                    ${GEN_CERT_OUTPUT_DIR}
    #                    DEPENDS
    #                    ${OPCUA_DIR}/tools/ssl_host.cnf
    #                    ${OPCUA_DIR}/tools/create_self-signed.py
    #                    )
    
    add_custom_command(OUTPUT ${GEN_CERT_OUTPUT_DIR}/${HOSTNAME}_cert.der
                       ${GEN_CERT_OUTPUT_DIR}/${HOSTNAME}_key.der
                       PRE_BUILD
                       COMMAND ${PYTHON_EXECUTABLE} ${OPCUA_DIR}/tools/create_self-signed.py
                       --application-uri=${GEN_CERT_APP_URI}
                       --key=4096
                       --hostname=${HOSTNAME}
                       ${GEN_CERT_OUTPUT_DIR}
                       DEPENDS
                       ${OPCUA_DIR}/tools/ssl_host.cnf
                       ${OPCUA_DIR}/tools/create_self-signed.py
                       )

    add_custom_target(${GEN_CERT_TARGET_NAME}
                      DEPENDS
                      ${GEN_CERT_OUTPUT_DIR}/${HOSTNAME}_cert.der
                      ${GEN_CERT_OUTPUT_DIR}/${HOSTNAME}_key.der)
endfunction()

enable_testing()
