#!/bin/bash

sudo apt-get update
sudo apt-get install -y git build-essential gcc pkg-config cmake python3 python3-pip
sudo apt-get install -y libconfig-dev libconfig++-dev
python3 -m pip install netifaces

git clone https://github.com/open62541/open62541.git
cd ./open62541
git checkout v1.3
git submodule update --init --recursive
mkdir build
cd ./build
cmake .. -DUA_ENABLE_SUBSCRIPTIONS_EVENTS=ON -DUA_NAMESPACE_ZERO=FULL -DUA_ENABLE_DISCOVERY=ON -DUA_ENABLE_DISCOVERY_MULTICAST=ON -DBUILD_SHARED_LIBS=ON -DCMAKE_BUILD_TYPE=Release
make
sudo make install

cd ../../

sudo apt install libeigen3-dev libopencv-dev python3-opencv

git clone https://github.com/lucasdecamargo/opcua-pnp.git
cd opcua-pnp/
mkdir build
cd build/
cmake .. -DPYTHON_EXECUTABLE:FILEPATH=/usr/bin/python3
make