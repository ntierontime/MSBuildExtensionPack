CREATE PROCEDURE dbo.GetAscendantOfParentIdOfMSBuildExtensionPack_Organization
	-- Add the parameters for the stored procedure here
	 	@Id BigInt
AS
BEGIN

WITH TempView
	(
		[Id]
		, [ParentId]
		, [Name]
		, [IsSystemBuiltIn]
		, [UniqueIdentifier]
		, [CreatedDateTime]
		, [CharColumn]
		, [VarcharColumn]
		, [TextColumn]
		, [NcharColumn]
		, [NvarcharColumn]
		, [NtextColumn]
		, [BitColumn]
		, [BinaryColumn]
		, [VarbinaryColumn]
		, [ImageColumn]
		, [TinyintColumn]
		, [SmallintColumn]
		, [IntColumn]
		, [BigintColumn]
		, [DecimalColumn]
		, [NumericColumn]
		, [SmallmoneyColumn]
		, [MoneyColumn]
		, [FloatColumn]
		, [RealColumn]
		, [DatetimeColumn]
		, [Datetime2Column]
		, [SmalldatetimeColumn]
		, [DateColumn]
		, [TimeColumn]
		, [UniqueidentifierColumn]
	, [Path]
	)
	AS 
	(
		SELECT     
			[Id]
			, [ParentId]
			, [Name]
			, [IsSystemBuiltIn]
			, [UniqueIdentifier]
			, [CreatedDateTime]
			, [CharColumn]
			, [VarcharColumn]
			, [TextColumn]
			, [NcharColumn]
			, [NvarcharColumn]
			, [NtextColumn]
			, [BitColumn]
			, [BinaryColumn]
			, [VarbinaryColumn]
			, [ImageColumn]
			, [TinyintColumn]
			, [SmallintColumn]
			, [IntColumn]
			, [BigintColumn]
			, [DecimalColumn]
			, [NumericColumn]
			, [SmallmoneyColumn]
			, [MoneyColumn]
			, [FloatColumn]
			, [RealColumn]
			, [DatetimeColumn]
			, [Datetime2Column]
			, [SmalldatetimeColumn]
			, [DateColumn]
			, [TimeColumn]
			, [UniqueidentifierColumn]
			, CAST(T.[Id] AS varchar(MAX)) AS [Path]
		FROM [dbo].[Organization] T
		WHERE ([Id]=@Id)
		UNION ALL
		SELECT 
			T1.[Id]
			, T1.[ParentId]
			, T1.[Name]
			, T1.[IsSystemBuiltIn]
			, T1.[UniqueIdentifier]
			, T1.[CreatedDateTime]
			, T1.[CharColumn]
			, T1.[VarcharColumn]
			, T1.[TextColumn]
			, T1.[NcharColumn]
			, T1.[NvarcharColumn]
			, T1.[NtextColumn]
			, T1.[BitColumn]
			, T1.[BinaryColumn]
			, T1.[VarbinaryColumn]
			, T1.[ImageColumn]
			, T1.[TinyintColumn]
			, T1.[SmallintColumn]
			, T1.[IntColumn]
			, T1.[BigintColumn]
			, T1.[DecimalColumn]
			, T1.[NumericColumn]
			, T1.[SmallmoneyColumn]
			, T1.[MoneyColumn]
			, T1.[FloatColumn]
			, T1.[RealColumn]
			, T1.[DatetimeColumn]
			, T1.[Datetime2Column]
			, T1.[SmalldatetimeColumn]
			, T1.[DateColumn]
			, T1.[TimeColumn]
			, T1.[UniqueidentifierColumn]
			, CAST(CTE.[Path] +'$'+CAST(T1.[Id] AS varchar(MAX)) AS varchar(MAX)) AS [Path]
		FROM         TempView AS CTE 
		CROSS JOIN [dbo].[Organization] AS T1 
		WHERE CTE.[ParentId]= T1.[Id] AND NOT(CTE.[Id]= T1.[Id])
	)
	
SELECT * FROM TempView
ORDER BY Path DESC
END

GO

CREATE PROCEDURE dbo.GetDescendantOfParentIdOfMSBuildExtensionPack_Organization
	-- Add the parameters for the stored procedure here
	 	@Id BigInt
AS
BEGIN

WITH TempView
	(
		[Id]
		, [ParentId]
		, [Name]
		, [IsSystemBuiltIn]
		, [UniqueIdentifier]
		, [CreatedDateTime]
		, [CharColumn]
		, [VarcharColumn]
		, [TextColumn]
		, [NcharColumn]
		, [NvarcharColumn]
		, [NtextColumn]
		, [BitColumn]
		, [BinaryColumn]
		, [VarbinaryColumn]
		, [ImageColumn]
		, [TinyintColumn]
		, [SmallintColumn]
		, [IntColumn]
		, [BigintColumn]
		, [DecimalColumn]
		, [NumericColumn]
		, [SmallmoneyColumn]
		, [MoneyColumn]
		, [FloatColumn]
		, [RealColumn]
		, [DatetimeColumn]
		, [Datetime2Column]
		, [SmalldatetimeColumn]
		, [DateColumn]
		, [TimeColumn]
		, [UniqueidentifierColumn]
	, [Path]
	)
	AS 
	(
		SELECT     
			[Id]
			, [ParentId]
			, [Name]
			, [IsSystemBuiltIn]
			, [UniqueIdentifier]
			, [CreatedDateTime]
			, [CharColumn]
			, [VarcharColumn]
			, [TextColumn]
			, [NcharColumn]
			, [NvarcharColumn]
			, [NtextColumn]
			, [BitColumn]
			, [BinaryColumn]
			, [VarbinaryColumn]
			, [ImageColumn]
			, [TinyintColumn]
			, [SmallintColumn]
			, [IntColumn]
			, [BigintColumn]
			, [DecimalColumn]
			, [NumericColumn]
			, [SmallmoneyColumn]
			, [MoneyColumn]
			, [FloatColumn]
			, [RealColumn]
			, [DatetimeColumn]
			, [Datetime2Column]
			, [SmalldatetimeColumn]
			, [DateColumn]
			, [TimeColumn]
			, [UniqueidentifierColumn]
			, CAST(T.[Id] AS varchar(MAX)) AS [Path]
		FROM [dbo].[Organization] T
		WHERE ([Id]=@Id)
		UNION ALL
		SELECT 
			T1.[Id]
			, T1.[ParentId]
			, T1.[Name]
			, T1.[IsSystemBuiltIn]
			, T1.[UniqueIdentifier]
			, T1.[CreatedDateTime]
			, T1.[CharColumn]
			, T1.[VarcharColumn]
			, T1.[TextColumn]
			, T1.[NcharColumn]
			, T1.[NvarcharColumn]
			, T1.[NtextColumn]
			, T1.[BitColumn]
			, T1.[BinaryColumn]
			, T1.[VarbinaryColumn]
			, T1.[ImageColumn]
			, T1.[TinyintColumn]
			, T1.[SmallintColumn]
			, T1.[IntColumn]
			, T1.[BigintColumn]
			, T1.[DecimalColumn]
			, T1.[NumericColumn]
			, T1.[SmallmoneyColumn]
			, T1.[MoneyColumn]
			, T1.[FloatColumn]
			, T1.[RealColumn]
			, T1.[DatetimeColumn]
			, T1.[Datetime2Column]
			, T1.[SmalldatetimeColumn]
			, T1.[DateColumn]
			, T1.[TimeColumn]
			, T1.[UniqueidentifierColumn]
			, CAST(CTE.[Path] +'$'+CAST(T1.[Id] AS varchar(MAX)) AS varchar(MAX)) AS [Path]
		FROM         TempView AS CTE 
		CROSS JOIN [dbo].[Organization] AS T1 
		WHERE CTE.[Id]= T1.[ParentId] AND NOT(CTE.[Id]= T1.[Id])
	)
	
SELECT * FROM TempView
END

GO