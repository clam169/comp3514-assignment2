#!/bin/bash

cd SpeakerLibrary
rm -rf dist
dotnet publish -o dist
cd ..
cd SpeakerAPI
rm -rf dist
dotnet publish -o dist
cd ..
cd BlazorClient
rm -rf dist
dotnet publish -o dist
cd ..
