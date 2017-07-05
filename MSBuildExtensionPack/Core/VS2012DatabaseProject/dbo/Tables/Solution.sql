/****** Object:  Table [dbo].[Solution]    ******/
CREATE TABLE [dbo].[Solution] (
	[Id] Int IDENTITY(1, 1) NOT NULL
	, [ExternalParentId] NVarChar(100)  NULL
	, [Name] NVarChar(100)  NOT NULL
	, [Description] NVarChar(1500)  NULL
	, [OrganizationId] BigInt  NULL
	, PRIMARY KEY NONCLUSTERED (
		Id ASC
		)
	, CONSTRAINT FK_Solution_OrganizationId FOREIGN KEY (OrganizationId) 
	    REFERENCES [dbo].[Organization] (Id) 
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
);


