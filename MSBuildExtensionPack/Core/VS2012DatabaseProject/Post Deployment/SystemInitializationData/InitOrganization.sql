/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
SET IDENTITY_INSERT [dbo].[Organization] ON

/* This is a template of insert data into a table, either system initialization data or test data.
INSERT INTO [dbo].[Organization]
(
		[Id]
		,[ParentId]
		,[Name]
		,[IsSystemBuiltIn]
		,[UniqueIdentifier]
		,[CreatedDateTime]
		,[CharColumn]
		,[VarcharColumn]
		,[TextColumn]
		,[NcharColumn]
		,[NvarcharColumn]
		,[NtextColumn]
		,[BitColumn]
		,[TinyintColumn]
		,[SmallintColumn]
		,[IntColumn]
		,[BigintColumn]
		,[DecimalColumn]
		,[NumericColumn]
		,[SmallmoneyColumn]
		,[MoneyColumn]
		,[FloatColumn]
		,[RealColumn]
		,[DatetimeColumn]
		,[Datetime2Column]
		,[SmalldatetimeColumn]
		,[DateColumn]
		,[TimeColumn]
		,[UniqueidentifierColumn]
)
VALUES
(
		0
		,0
		,""
		,0
		,NEWID()
		,GETDATE()
		,""
		,""
		,""
		,""
		,""
		,""
		,0
		,0
		,0
		,0
		,0
		,0
		,0
		,0
		,0
		,0
		,0
		,GETDATE()
		,GETDATE()
		,GETDATE()
		,GETDATE()
		,""
		,NEWID()
)


UPDATE dbo.Organization
SET [BinaryColumn] = (SELECT BulkColumn FROM OPENROWSET (BULK '', SINGLE_BLOB) a) 
WHERE (??Condition??) --##
UPDATE dbo.Organization
SET [VarbinaryColumn] = (SELECT BulkColumn FROM OPENROWSET (BULK '', SINGLE_BLOB) a) 
WHERE (??Condition??) --##
UPDATE dbo.Organization
SET [ImageColumn] = (SELECT BulkColumn FROM OPENROWSET (BULK '', SINGLE_BLOB) a) 
WHERE (??Condition??) --

*/

SET IDENTITY_INSERT [dbo].[Organization] OFF

