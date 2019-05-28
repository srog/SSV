CREATE PROCEDURE [dbo].[spGetEvent]
	@id int 
AS
	SELECT * FROM [Event] WHERE [Id] = @id
RETURN 0
