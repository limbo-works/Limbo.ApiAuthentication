@echo off
dotnet build src/Limbo.ApiAuthentication --configuration Debug /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../debug/nuget
dotnet build src/Limbo.ApiAuthentication.Persistence --configuration Debug /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../debug/nuget