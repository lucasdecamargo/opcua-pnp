#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting Composite Skills component ..."
$<TARGET_FILE:mes> --config /home/lucas/Coding/OPCUA/opcua-pnp/component.cfg --certs-server=/home/lucas/Coding/OPCUA/opcua-pnp/certs/server/lucas-laptop --certs-client=/home/lucas/Coding/OPCUA/opcua-pnp/certs/client/lucas-laptop &
P_mes=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_mes
trap - SIGINT
wait $P_mes
