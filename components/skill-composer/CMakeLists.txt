cmake_minimum_required(VERSION 3.0.0)
project(skill-composer)

find_package(open62541 1.2 REQUIRED COMPONENTS FullNamespace Events)
find_package(OpenCV REQUIRED)

include(FetchContent)
FetchContent_Declare(
    cli11
    GIT_REPOSITORY https://github.com/CLIUtils/CLI11
    GIT_TAG        v2.2.0
)
FetchContent_MakeAvailable(cli11)

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
        FILE_CSV "${NODESET_DIR}/DeviceModel/Published/DeviceModel/DeviceModel.csv"
        FILE_BSD "${NODESET_DIR}/DeviceModel/Published/DeviceModel/fortiss_Device.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "3:https://fortiss.org/UA/Device/"
        FILE_NS "${NODESET_DIR}/DeviceModel/Published/DeviceModel/fortiss_Device.NodeSet2.xml"
        DEPENDS "di"
        INTERNAL
)

ua_generate_nodeset_and_datatypes(
        NAME "pnp_types"
        TARGET_PREFIX "${PROJECT_NAME}"
        FILE_CSV "${NODESET_DIR}/PnPTypes/Published/PnPTypes/PnPTypes.csv"
        FILE_BSD "${NODESET_DIR}/PnPTypes/Published/PnPTypes/PnPTypes.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "4:https://pnp.org/UA/PnPTypes/"
        FILE_NS "${NODESET_DIR}/PnPTypes/Published/PnPTypes/PnPTypes.NodeSet2.xml"
        DEPENDS "device_model" "di"
        INTERNAL
)

ua_generate_nodeset_and_datatypes(
        NAME "skill_composer"
        TARGET_PREFIX "${PROJECT_NAME}"
        FILE_CSV "${CMAKE_CURRENT_LIST_DIR}/model/Published/SkillComposerModel/SkillComposerModel.csv"
        FILE_BSD "${CMAKE_CURRENT_LIST_DIR}/model/Published/SkillComposerModel/SkillComposer.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "5:https://pnp.org/UA/SkillComposer/"
        FILE_NS "${CMAKE_CURRENT_LIST_DIR}/model/Published/SkillComposerModel/SkillComposer.NodeSet2.xml"
        DEPENDS "pnp_types"
        INTERNAL
)

generate_certificate(
        TARGET_NAME "skill-composer-certs-server"
        APP_URI "pnp.component.skillcomposer"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/certs/server"
)

generate_certificate(
        TARGET_NAME "skill-composer-certs-client"
        APP_URI "pnp.component.skillcomposer.client"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/certs/client"
)

include_directories(
    lib
    ${GENERATE_OUTPUT_DIR}
)

add_library(${PROJECT_NAME}-lib
    ${UA_NODESET_DI_SOURCES}
    ${UA_TYPES_DI_SOURCES}
    ${UA_NODESET_DEVICE_MODEL_SOURCES}
    ${UA_TYPES_DEVICE_MODEL_SOURCES}
    ${UA_NODESET_PNP_TYPES_SOURCES}
    ${UA_TYPES_PNP_TYPES_SOURCES}
    ${UA_NODESET_SKILL_COMPOSER_SOURCES}
    ${UA_TYPES_SKILL_COMPOSER_SOURCES}
    src/SkillComposer.cpp
    src/MarkerFindingSkillImpl.cpp
    src/CameraClient.cpp
)

target_link_libraries(${PROJECT_NAME}-lib
    CLI11::CLI11
    config++
    open62541::open62541
    ${OPCUA_LIB}
    ${OPCUA_CLIENT_LIB}
)

add_dependencies(${PROJECT_NAME}-lib
    skill-composer-ns-di
    skill-composer-ns-device_model
    skill-composer-ns-pnp_types
    skill-composer-ns-skill_composer
    skill-composer-certs-server
    skill-composer-certs-client
)

add_executable(${PROJECT_NAME}
        src/main.cpp
)

target_link_libraries(${PROJECT_NAME}
        ${PROJECT_NAME}-lib
)

add_dependencies(${PROJECT_NAME}
        ${PROJECT_NAME}-lib
)

if(OPCUA_PNP_COMPILE_TESTS)
    add_subdirectory(test)
endif()

cmake_host_system_information(RESULT HOSTNAME QUERY HOSTNAME)
file(GENERATE OUTPUT "${CMAKE_SOURCE_DIR}/run_skillcomposer.sh" INPUT "${PROJECT_BINARY_DIR}/.run_tmp.sh")
configure_file("run_template.in.sh" "${PROJECT_BINARY_DIR}/.run_tmp.sh")