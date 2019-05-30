CREATE PROCEDURE [dbo].[spUpdateToDoItem]
	@id int,
	@userId int,
	@name nvarchar(250),
	@status int
AS
	UPDATE [ToDoItem] SET [Status] = @status, [Name] = @name 
	WHERE [Id] = @id
RETURN 0
