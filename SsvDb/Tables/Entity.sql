CREATE TABLE [dbo].[Entity]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(250),
	[Created] DATETIME,
	[EntityType] INT
)
