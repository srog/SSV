CREATE PROCEDURE [dbo].[spGetMusicDetails]
	@entityId int
AS
	SELECT * FROM [Music] WHERE [EntityId] = @entityId
RETURN 0
