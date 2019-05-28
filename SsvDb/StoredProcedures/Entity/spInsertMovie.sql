CREATE PROCEDURE [dbo].[spInsertMovie]
	@entityId int,
	@name nvarchar(250),
	@imageFilePath nvarchar(250),
	@imdbLink nvarchar(250),
	@imdbRating decimal,
	@yearReleased int
AS
	INSERT INTO [Movie] ([EntityId], [Name], [ImageFilePath], [ImdbLink], [ImdbRating], [YearReleased])
	VALUES (@entityId, @name, @imageFilePath, @imdbLink, @imdbRating, @yearReleased)

RETURN 0