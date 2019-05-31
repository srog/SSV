CREATE PROCEDURE [dbo].[spGetToDoItems]
	@userId int
AS
	SELECT * FROM [ToDoItem] WHERE [UserId] = @userId AND [Status] = 1
RETURN 0
