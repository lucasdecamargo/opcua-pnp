
add_executable(${PROJECT_NAME}-test-aruco
    aruco_test.cpp
)

target_link_libraries(${PROJECT_NAME}-test-aruco
    ${OpenCV_LIBS}
    ${ARUCO_LIBRARIES}
)

target_compile_definitions(${PROJECT_NAME}-test-aruco PRIVATE
    IMG_MARKERS="${CMAKE_CURRENT_LIST_DIR}/markers.jpg"
    MARKERS_CSV="${CMAKE_CURRENT_LIST_DIR}/markers.csv"
)