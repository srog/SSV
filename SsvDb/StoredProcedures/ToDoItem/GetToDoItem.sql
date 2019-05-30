CREATE PROCEDURE [dbo].[spGetToDoItem]
	@id int
AS
	SELECT * FROM [ToDoItem] WHERE [Id] = @id
RETURN 0
