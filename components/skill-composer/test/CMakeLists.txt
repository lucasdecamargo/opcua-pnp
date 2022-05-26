
add_executable(${PROJECT_NAME}-test-event-client
    event_client.cpp
)

target_link_libraries(${PROJECT_NAME}-test-event-client
    open62541::open62541
)
