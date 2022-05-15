set(GENERATE_OUTPUT_DIR "${CMAKE_BINARY_DIR}/src_generated/${PROJECT_NAME}-client")

file(MAKE_DIRECTORY "${GENERATE_OUTPUT_DIR}")

set(PREFIX ${PROJECT_NAME})

ua_generate_nodeset_and_datatypes(
        NAME "di"
        TARGET_PREFIX "${PREFIX}"
        FILE_CSV "${open62541_NODESET_DIR}/DI/OpcUaDiModel.csv"
        FILE_BSD "${open62541_NODESET_DIR}/DI/Opc.Ua.Di.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "2:http://opcfoundation.org/UA/DI/"
        FILE_NS "${open62541_NODESET_DIR}/DI/Opc.Ua.Di.NodeSet2.xml"
        INTERNAL
)

ua_generate_nodeset_and_datatypes(
        NAME "device_model"
        TARGET_PREFIX "${PREFIX}"
        FILE_CSV "${CMAKE_CURRENT_LIST_DIR}/DeviceModel/Published/DeviceModel/DeviceModel.csv"
        FILE_BSD "${CMAKE_CURRENT_LIST_DIR}/DeviceModel/Published/DeviceModel/fortiss_Device.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_MAP "3:https://fortiss.org/UA/Device/"
        FILE_NS "${CMAKE_CURRENT_LIST_DIR}/DeviceModel/Published/DeviceModel/fortiss_Device.NodeSet2.xml"
        DEPENDS "di"
        INTERNAL
)

add_library(${PROJECT_NAME}-nodeset OBJECT
            ${UA_NODESET_DI_SOURCES}
            ${UA_NODESET_DEVICE_MODEL_SOURCES}
            ${UA_TYPES_DI_SOURCES}
            ${UA_TYPES_DEVICE_MODEL_SOURCES})

target_include_directories(${PROJECT_NAME}-nodeset PUBLIC
                           ${GENERATE_OUTPUT_DIR}
                           $<TARGET_PROPERTY:open62541::open62541,INTERFACE_INCLUDE_DIRECTORIES>)

# add_dependencies(${PROJECT_NAME}-nodeset
# )
