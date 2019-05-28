CREATE PROCEDURE [dbo].[spGetAllMovies]

AS
	SELECT * FROM [Entity] WHERE [EntityType] = 1
RETURN 0
