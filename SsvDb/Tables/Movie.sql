CREATE TABLE [dbo].[Movie]
(
	[EntityId] INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(250),
	[ImageFilePath] NVARCHAR(250),
	[ImdbLink] NVARCHAR(250),
	[ImdbRating] DECIMAL,
	[YearReleased] INT

)
