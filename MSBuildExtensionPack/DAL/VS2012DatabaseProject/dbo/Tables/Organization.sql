/****** Object:  Table [dbo].[Organization]    ******/
CREATE TABLE [dbo].[Organization] (
	[Id] BigInt IDENTITY(1, 1) NOT NULL
	, [ParentId] BigInt  NOT NULL
	, [Name] VarChar(50)  NOT NULL
	, [IsSystemBuiltIn] Bit  NOT NULL
	, [UniqueIdentifier] UniqueIdentifier  NOT NULL
	, [CreatedDateTime] DateTime  NOT NULL
	, [CharColumn] Char(10)  NOT NULL
	, [VarcharColumn] VarChar(MAX)  NOT NULL
	, [TextColumn] Text  NOT NULL
	, [NcharColumn] NChar(1)  NOT NULL
	, [NvarcharColumn] NVarChar(MAX)  NOT NULL
	, [NtextColumn] NText  NOT NULL
	, [BitColumn] Bit  NOT NULL
	, [BinaryColumn] Binary(10)  NULL
	, [VarbinaryColumn] VarBinary(MAX)  NULL
	, [ImageColumn] Image  NULL
	, [TinyintColumn] TinyInt  NOT NULL
	, [SmallintColumn] SmallInt  NOT NULL
	, [IntColumn] Int  NOT NULL
	, [BigintColumn] BigInt  NOT NULL
	, [DecimalColumn] Decimal(10,2)  NOT NULL
	, [NumericColumn] Decimal(10,2)  NOT NULL
	, [SmallmoneyColumn] SmallMoney  NOT NULL
	, [MoneyColumn] Money  NOT NULL
	, [FloatColumn] Real  NOT NULL
	, [RealColumn] Real  NOT NULL
	, [DatetimeColumn] DateTime  NOT NULL
	, [Datetime2Column] DateTime2(7)  NOT NULL
	, [SmalldatetimeColumn] SmallDateTime  NOT NULL
	, [DateColumn] Date  NOT NULL
	, [TimeColumn] Time(7)  NOT NULL
	, [UniqueidentifierColumn] UniqueIdentifier  NOT NULL
	, PRIMARY KEY NONCLUSTERED (
		Id ASC
		)
	, CONSTRAINT FK_Organization_ParentId FOREIGN KEY (ParentId) 
	    REFERENCES [dbo].[Organization] (Id) 
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
	, CONSTRAINT [UC_Organization_UniqueIdentifier] UNIQUE NONCLUSTERED(UniqueIdentifier)
	, CONSTRAINT [UC_Organization_UniqueidentifierColumn] UNIQUE NONCLUSTERED(UniqueidentifierColumn)
);


