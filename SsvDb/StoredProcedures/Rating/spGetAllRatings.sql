CREATE PROCEDURE [dbo].[spGetAllRatings]

AS
	SELECT TOP 1000 r.*, e.[Name] AS 'EntityDescription'
	FROM [Rating] r
	INNER JOIN [Entity] e ON e.Id = r.EntityId

RETURN 0
