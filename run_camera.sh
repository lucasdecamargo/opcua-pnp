#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting Camera component ..."
/home/lucas/Coding/OPCUA/opcua-pnp/build/components/camera/camera --config /home/lucas/Coding/OPCUA/opcua-pnp/components/camera/component.cfg --certs-server=/home/lucas/Coding/OPCUA/opcua-pnp/components/camera/certs/server/lucas-laptop --certs-client=/home/lucas/Coding/OPCUA/opcua-pnp/components/camera/certs/client/lucas-laptop &
P_camera=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_camera
trap - SIGINT
wait $P_camera
