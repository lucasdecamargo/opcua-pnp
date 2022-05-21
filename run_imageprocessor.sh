#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting Image Processor component ..."
/home/lucas/Coding/OPCUA/opcua-pnp/build/components/image-processor/image-processor --config /home/lucas/Coding/OPCUA/opcua-pnp/components/image-processor/component.cfg --certs-server=/home/lucas/Coding/OPCUA/opcua-pnp/components/image-processor/certs/server/lucas-laptop --certs-client=/home/lucas/Coding/OPCUA/opcua-pnp/components/image-processor/certs/client/lucas-laptop --markers-file=/home/lucas/Coding/OPCUA/opcua-pnp/components/image-processor/test/markers.csv &
P_imgprocessor=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_imgprocessor
trap - SIGINT
wait $P_imgprocessor
