CREATE PROCEDURE [dbo].[spInsertMusic]
	@entityId int,
	@name nvarchar(250),
	@imageFilePath nvarchar(250),
	@spotifyLink nvarchar(250),
	@yearReleased int
AS
	INSERT INTO [Music] ([EntityId], [Name], [ImageFilePath], [SpotifyLink], [YearReleased])
	VALUES (@entityId, @name, @imageFilePath, @spotifyLink, @yearReleased)

RETURN 0