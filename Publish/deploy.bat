@echo off

@if "%1" == "" goto Usage

@echo Processing Codev.TimeCog.Sync
@tools\nuget.exe push nupkg/Codev.TimeCog.Sync.%1.nupkg %GITHUB_NUGET_TOKEN% -Source https://nuget.pkg.github.com/codev-software-llc/index.json

goto Done

:Usage
@echo Usage: deploy.bat [version]

:Done