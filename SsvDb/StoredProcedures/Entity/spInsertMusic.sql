CREATE PROCEDURE [dbo].[spInsertMusic]
	@entityId int,
	@name nvarchar(250),
	@imageFilePath nvarchar(250),
	@spotifyLink nvarchar(250),
	@yearReleased int,
	@id int output
AS
	DECLARE @result int

	INSERT INTO [Music] ([EntityId], [Name], [ImageFilePath], [SpotifyLink], [YearReleased])
	VALUES (@entityId, @name, @imageFilePath, @spotifyLink, @yearReleased)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result