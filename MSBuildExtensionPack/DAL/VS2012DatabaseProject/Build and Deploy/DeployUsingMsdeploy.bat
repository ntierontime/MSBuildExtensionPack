"C:\Program Files (x86)\Microsoft SQL Server\110\DAC\bin\sqlpackage.exe" -verb:sync -source:dbSqlPackage="..\..\..\BuiltResults\MSBuildExtensionPack.VS2012DatabaseProject.dacpac",Profile="..\Publish Profles\Localhost.publish.xml" -dest:dbSqlPackage="Data Source=Localhost;Initial Catalog=MSBuildExtensionPack;UID=sa;PWD=Qwer~123;",Action=Publish

