CREATE PROCEDURE [dbo].[spGetRatingsForEntity]
	@entityId int
AS
	SELECT r.*, e.[Name] AS 'EntityDescription'
	FROM [Rating] r
	INNER JOIN [Entity] e ON e.Id = r.EntityId
	WHERE [EntityId] = @entityId
RETURN 0
