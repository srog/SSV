CREATE PROCEDURE [dbo].[spGetToDoItems]
	@userId int
AS
	SELECT * FROM [ToDoItem] WHERE [UserId] = @userId
RETURN 0
