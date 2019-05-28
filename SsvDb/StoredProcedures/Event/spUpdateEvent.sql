CREATE PROCEDURE [dbo].[spUpdateEvent]
	@id int,
	@status int
AS
	UPDATE [Event] SET [Status] = @status WHERE [Id] = @id
RETURN 0
