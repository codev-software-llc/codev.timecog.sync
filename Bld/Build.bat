@rem --------------------------------------------------------------------------
@rem This will build all the target configurations.
@rem --------------------------------------------------------------------------
@echo off

pushd %~dp0%


@rem ----------------------------------------------------------------
@rem First clean all the targets.
@rem ----------------------------------------------------------------
call Clean.bat


@rem ----------------------------------------------------------------
@rem Run the build script.
@rem ----------------------------------------------------------------
pushd ..\
FOR %%X IN (Dev,Live) DO (
  @echo Build - Codev.TimeCog.Sync [%%X]
  dotnet build --configuration %%X /p:WarningLevel=0 /restore:true /verbosity:quiet
)
popd


@rem ----------------------------------------------------------------
@rem Restore the directory.
@rem ----------------------------------------------------------------
popd
