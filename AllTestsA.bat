SET server=localhost
SET database=MSBuildExtensionPack
SET user=sa
SET password=Qwer~123

git checkout foo || git checkout -b foo

RD Frameworks /S /Q
RD Frameworks.X /S /Q
RD %database% /S /Q
DEL *.sln /S /Q

D:\Test4\WhatEverII\trunk\BuiltResults\Dbml.CommandLine\nTierCraft.T4Parser.FileBuilders.Generated.Dbml.CommandLine.exe -o LoadQuickCodeGenConfigurationCmdLineArgPerSolution -r "D:\Github\%database%"

git add -A
git commit -m test2
git push

copy "D:\Test4\WhatEverII\trunk\TestCertificates\UWPApp_TemporaryKey.pfx.copy" %database%\UI\MVVMLight\UWPApp\%database%.UWPApp_TemporaryKey.pfx

"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" %database%\UI\MVVMLight\AndroidApp\%database%.AndroidApp.csproj /p:Configuration=Release

"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" %database%\UI\MVVMLight\IOSApp\%database%.IOSApp.csproj /p:Configuration=Release

"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" %database%\UI\MVVMLight\UWPApp\%database%.UWPApp.csproj /p:Configuration=Release

"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" %database%\UI\MVVMLight\WPF4App\%database%.WPF4App.csproj /p:Configuration=Release

"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" %database%\UI\Web\AspNetMvc40Rasor\%database%.AspNetMvc40Rasor.csproj /p:Configuration=Release

git add -A
git diff --quiet && git diff --staged --quiet || git commit -m 'test'
git push
