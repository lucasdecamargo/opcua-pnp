cmake_minimum_required(VERSION 3.0.0)
project(mes)

find_package(open62541 1.0 REQUIRED COMPONENTS FullNamespace Events Discovery DiscoveryMulticast)

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

generate_certificate(
        TARGET_NAME "mes-certs-server"
        APP_URI "pnp.component.mes"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/certs/server"
)

generate_certificate(
        TARGET_NAME "mes-certs-client"
        APP_URI "pnp.component.mes.client"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/certs/client"
)

include_directories(
    lib
    ${GENERATE_OUTPUT_DIR}
)

add_executable(${PROJECT_NAME} 
    src/main.cpp
    src/MES.cpp
)

target_link_libraries(${PROJECT_NAME}
    CLI11::CLI11
    config++
    open62541::open62541
    ${OPCUA_LIB}
)

add_dependencies(${PROJECT_NAME}
    mes-certs-server
    mes-certs-client
)

cmake_host_system_information(RESULT HOSTNAME QUERY HOSTNAME)
file(GENERATE OUTPUT "${CMAKE_SOURCE_DIR}/run_mes.sh" INPUT "${PROJECT_BINARY_DIR}/.run_tmp.sh")
configure_file("run_template.in.sh" "${PROJECT_BINARY_DIR}/.run_tmp.sh")