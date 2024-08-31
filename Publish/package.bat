@echo off

@if /I "%1" == "" goto Usage

pushd .\specs

@echo Processing Codev.TimeCog.Sync
@..\tools\nuget.exe pack Codev.TimeCog.Sync.nuspec -version %1 -OutputDirectory ..\nupkg

popd

goto Done

:Usage
@echo Usage: package.exe [version]

:Done