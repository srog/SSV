CREATE PROCEDURE [dbo].[spDeleteEvent]
	@id int

AS
	DELETE FROM [Event] WHERE [Id] = @id
RETURN 0
