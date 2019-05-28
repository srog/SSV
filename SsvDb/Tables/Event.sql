CREATE TABLE [dbo].[Event]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[UserId] INT NOT NULL,
	[IsPublic] BIT NOT NULL,
	[Name] NVARCHAR(250),
	[Description] NVARCHAR(MAX),
	[EventStart] DATETIME,
	[EventEnd] DATETIME,
	[Location] NVARCHAR(250),
	[Status] INT
)
