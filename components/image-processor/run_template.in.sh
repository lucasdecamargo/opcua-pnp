#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting Image Processor component ..."
$<TARGET_FILE:image-processor> --config ${CMAKE_CURRENT_LIST_DIR}/component.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/certs/client/${HOSTNAME} --markers-file=${CMAKE_CURRENT_LIST_DIR}/test/markers.csv &
P_imgprocessor=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_imgprocessor
trap - SIGINT
wait $P_imgprocessor
