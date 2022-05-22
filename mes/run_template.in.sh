#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting MES component ..."
$<TARGET_FILE:mes> --config ${CMAKE_CURRENT_LIST_DIR}/component.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/certs/client/${HOSTNAME} &
P_mes=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_mes
trap - SIGINT
wait $P_mes
