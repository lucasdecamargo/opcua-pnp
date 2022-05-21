#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting Image Viewer ..."
/home/lucas/Coding/OPCUA/opcua-pnp/build/components/camera/camera-img-viewer --config /home/lucas/Coding/OPCUA/opcua-pnp/components/camera/img_viewer_component.cfg --certs-client=/home/lucas/Coding/OPCUA/opcua-pnp/components/camera/certs/client/lucas-laptop &
P_imgviewer=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_imgviewer
trap - SIGINT
wait $P_imgviewer
