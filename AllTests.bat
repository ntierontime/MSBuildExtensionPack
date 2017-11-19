git checkout foo || git checkout -b fooRD MSBuildExtensionPack /S /Q
RD Frameworks /S /Q
RD Frameworks.X /S /Q
RD MSBuildExtensionPack /S /Q
DEL *.sln /S /Q

SET server=localhost
SET database=MSBuildExtensionPack
SET user=sa
SET password=Qwer~123

D:\Test4\WhatEverII\trunk\BuiltResults\Dbml.CommandLine\nTierCraft.T4Parser.FileBuilders.Generated.Dbml.CommandLine.exe -o LoadQuickCodeGenConfigurationCmdLineArgPerSolution -r "D:\Github\%database%"

git add -A

git commit -m test2