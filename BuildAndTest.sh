#!/bin/bash

while getopts c: option
do
	case "${option}" in
		c) CONFIG=${OPTARG};;
	esac
done

CONFIG=${CONFIG:-Debug}

hash dotnet 2>/dev/null || { echo >&2 "Cannot run dotnet cli... aborting"; exit 1; }

echo "=====Using $CONFIG configuration====="

echo "=====Building solution=====" 
if ! dotnet build -c $CONFIG ./DonDaoTest.sln; then
	echo "build failed... aborting"
	exit 1
fi

echo "Running Tests"
dotnet test -c $CONFIG ./DonDaoTest.sln
