@rem ----------------------------------------------------------------
@rem Setup the script.  This will save the current directory.
@rem ----------------------------------------------------------------
@echo off
@echo Clean - Codev.Core

pushd %~dp0%


@rem ----------------------------------------------------------------
@rem Run the clean script.
@rem ----------------------------------------------------------------
pushd ..\Publish

@if EXIST bin (
  rd /s /q bin
)
popd


FOR %%X IN (Sync) DO (

    @if EXIST "..\%%X" (

        pushd ..\%%X

        FOR %%Y IN (obj,bin) DO (
            @if EXIST %%Y (
                rd /s /q %%Y
            )
        )

        popd

    )
)


@rem ----------------------------------------------------------------
@rem Restore the directory.
@rem ----------------------------------------------------------------
popd