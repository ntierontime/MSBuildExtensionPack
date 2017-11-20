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

if [[ `git status --porcelain` ]]; then
	git add -A
	git commit -m test2
	git push
else
  # no changes
fi