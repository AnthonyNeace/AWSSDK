#!/bin/bash
# PowerShell script to download the latest (as of Oct 2012) ActiveWorlds library for Windows and Linux
# - Roy Curtis
#####

# To update this script, change the values below
BUILD=100
AWLIB_WIN="http://objects.activeworlds.com/downloads/awsdk$BUILD.zip"
AWLIB_LINUX="http://objects.activeworlds.com/downloads/awsdk$BUILD.tar.gz"
#####

echo "This will download the AW SDK from the official website into the Build/ directory."
read -p "Press [ENTER] to continue (assumes you agree with the Active Worlds SDK license agreement)"

echo
echo "Creating 'Build' directory..."
mkdir Build

echo
echo "Downloading AW SDK Build $BUILD for Windows..."
curl $AWLIB_WIN -o "Build/awsdk-win32.zip"

echo
echo "Downloading AW SDK Build $BUILD for Linux..."
curl $AWLIB_LINUX -o "Build/awsdk-linux.tar.gz"

echo
echo "Unzipping..."
cd Build
tar -xf *.tar.gz
unzip *.zip
rm -r *.zip *.tar.gz Makefile.sample README.sdk Readme.txt test.cpp License.txt

echo
echo
read -p "Investigate output for any errors, else press [ENTER] to exit."