@echo off
dotnet build src/Limbo.ApiAuthentication --configuration Release /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../releases/nuget
dotnet build src/Limbo.ApiAuthentication.Persistence --configuration Release /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../releases/nuget