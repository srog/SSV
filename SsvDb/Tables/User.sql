CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Fullname] NVARCHAR(250),
	[Username] NVARCHAR(250),
	[Password] NVARCHAR(20),
	[UserType] INT NOT NULL,
	[Email] NVARCHAR(250),
	[IsActive] BIT NOT NULL
)
