CREATE PROCEDURE [dbo].[spInsertMovie]
	@entityId int,
	@name nvarchar(250),
	@imageFilePath nvarchar(250),
	@imdbLink nvarchar(250),
	@imdbRating decimal,
	@yearReleased int,
	@id int output
AS
DECLARE @result int

	INSERT INTO [Movie] ([EntityId], [Name], [ImageFilePath], [ImdbLink], [ImdbRating], [YearReleased])
	VALUES (@entityId, @name, @imageFilePath, @imdbLink, @imdbRating, @yearReleased)


	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result