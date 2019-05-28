CREATE PROCEDURE [dbo].[spGetMovieDetails]
	@entityId int
AS
	SELECT * FROM [Movie] WHERE [EntityId] = @entityId
RETURN 0
