CREATE PROCEDURE [dbo].[spGetRatingsForEntity]
	@entityId int
AS
	SELECT * FROM [Rating] WHERE [EntityId] = @entityId
RETURN 0
