# Limbo.ApiAuthentication
Easy to setup api authentication using Asp Net Cores built-in workflow

## Content

- Install
- Description
- Documentation

### Install

```
dotnet add package Limbo.ApiAuthentication
```

### Description

This package adds easy to setup authentication for Asp Net Core. This uses api keys stored in a database with EF Core to add JWT authentication to any Asp Net Core application.

### Documentation

You can find the documentation [here](docs/index.md)

### Maintainer information

Here you'll find information for maintaining the repository

#### Test database

To get the test database up and running use:
```
docker-compose up -d
```
Exceuted in the root of the repository with [Docker](https://docs.docker.com/get-docker/) running.

#### Changelog

This repository uses `standard-version` to create changelogs using [conventional commits](https://www.conventionalcommits.org/en/v1.0.0/)


#### Releases

First change the version of the csproj file to the new version.

To create a release use the following commands:

Install packages
```
yarn
```

```
yarn release
```

This will create the nuget package at [Releases](./releases/nuget/) and update the changelog.

#### Prereleases

First change the version of the csproj file to the new version.

To create a prerelease use the following commands:

Install packages
```
yarn
```

```
yarn release --prerelease
```

This will create the nuget package at [Releases](./releases/nuget/) and update the changelog.

#### Debug

First change the version of the csproj file to the new version.

To create a debug nuget package use the following commands:

Install packages
```
yarn
```

```
yarn debug
```

This will create the nuget package at [debug](./debug/nuget/).