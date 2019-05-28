CREATE TABLE [dbo].[Blog]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(250),
	[Created] DATETIME,
	[CreatedByUser] int

)
