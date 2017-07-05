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
		,""
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
		,""
		,""
		,""
		,""
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