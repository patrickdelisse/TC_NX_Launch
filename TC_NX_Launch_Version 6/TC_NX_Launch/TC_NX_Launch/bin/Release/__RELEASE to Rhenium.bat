echo off

set TARGET=\\RHENIUM\PLMShare\PLM_Startup\Startups\bin\

rem copy _K*.vbs %TARGET%
copy TC*.exe %TARGET%
rem copy TC*.xml %TARGET%

pause
Exit
