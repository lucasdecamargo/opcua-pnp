cmake_minimum_required(VERSION 3.0.0)
project(opcua-pnp VERSION 0.1.0)

include(CTest)
enable_testing()

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})

option(OPCUA_PNP_COMPILE_TESTS "Enable to compile tests" ON)

add_definitions(
    -lconfig++
    -pthread
)

#####################
# OPC UA PNP ENGINE #
#####################
add_subdirectory(include/opcua)

set(OPCUA_LIB "${PROJECT_NAME}-opcua")
set(OPCUA_CLIENT_LIB "${PROJECT_NAME}-opcua-client")
set(NODESET_DIR "${CMAKE_CURRENT_LIST_DIR}/nodeset")

##################################
# MANUFACTURING EXECUTION SYSTEM #
##################################
add_subdirectory(mes)

###################
# I4.0 COMPONENTS #
###################
add_subdirectory(components/camera)
add_subdirectory(components/image-processor)
add_subdirectory(components/skill-composer)
