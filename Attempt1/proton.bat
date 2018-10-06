@echo off
pushd %~dp0
proton.exe --WatchFileEnable=true --WatchFile=./proton.proton,goap.proton,goap_debug.proton --CSharpContextAttributeGenerator_C_1_4_2=false
popd
pause