cmake_minimum_required(VERSION 3.0.0)
project(opcua-pnp VERSION 0.1.0)

include(CTest)
enable_testing()

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})

option(OPCUA_PNP_COMPILE_TESTS "Enable to compile tests" ON)

find_package(open62541 1.0 REQUIRED COMPONENTS FullNamespace Events Discovery DiscoveryMulticast)

add_definitions(
    -lconfig++
)

include(FetchContent)
FetchContent_Declare(
    cli11
    GIT_REPOSITORY https://github.com/CLIUtils/CLI11
    GIT_TAG        v2.2.0
)

FetchContent_MakeAvailable(cli11)

add_subdirectory(include/opcua)

set(OPCUA_LIB "${PROJECT_NAME}-opcua")
set(NODESET_DIR "${CMAKE_CURRENT_LIST_DIR}/nodeset")

###################
# I4.0 COMPONENTS #
###################
add_subdirectory(components/camera)
add_subdirectory(components/image-processor)

##################################
# MANUFACTURING EXECUTION SYSTEM #
##################################

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

add_executable(mes 
    main.cpp
    src/MES.cpp
)

target_link_libraries(mes
    CLI11::CLI11
    config++
    open62541::open62541
    ${PROJECT_NAME}-opcua
)

target_include_directories(mes PUBLIC
    lib
)

add_dependencies(mes
    mes-certs-server
    mes-certs-client
)

cmake_host_system_information(RESULT HOSTNAME QUERY HOSTNAME)
file(GENERATE OUTPUT "${CMAKE_SOURCE_DIR}/run_mes.sh" INPUT "${PROJECT_BINARY_DIR}/.run_tmp.sh")
configure_file("run_template.in.sh" "${PROJECT_BINARY_DIR}/.run_tmp.sh")
