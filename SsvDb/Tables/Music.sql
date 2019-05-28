CREATE TABLE [dbo].[Music]
(
	[EntityId] INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(250),
	[ImageFilePath] NVARCHAR(250),
	[SpotifyLink] NVARCHAR(250),
	[YearReleased] INT
)
