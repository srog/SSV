CREATE PROCEDURE [dbo].[spGetAllMusic]

AS
	SELECT * FROM [Entity] WHERE [EntityType] = 2
RETURN 0
