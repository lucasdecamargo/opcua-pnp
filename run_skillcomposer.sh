#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting Skill Composer component ..."
/home/lucas/Coding/OPCUA/opcua-pnp/build/components/skill-composer/skill-composer --config /home/lucas/Coding/OPCUA/opcua-pnp/components/skill-composer/component.cfg --certs-server=/home/lucas/Coding/OPCUA/opcua-pnp/components/skill-composer/certs/server/lucas-laptop --certs-client=/home/lucas/Coding/OPCUA/opcua-pnp/components/skill-composer/certs/client/lucas-laptop &
P_skill_composer=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_skill_composer
trap - SIGINT
wait $P_skill_composer
