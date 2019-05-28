CREATE TABLE [dbo].[Rating]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[EntityId] INT NOT NULL,
	[Created] DATETIME,
	[UserId] INT,
	[RatingValue] INT,
	[RatingText] NVARCHAR(MAX)
)
