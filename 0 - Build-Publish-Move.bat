@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.CodeDom.Vue\bin\Release\Panosen.CodeDom.Vue.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Vue.Engine\bin\Release\Panosen.CodeDom.Vue.Engine.*.nupkg D:\LocalSavoryNuget\

pause