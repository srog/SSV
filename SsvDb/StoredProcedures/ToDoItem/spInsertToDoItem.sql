CREATE PROCEDURE [dbo].[spInsertToDoItem]
	@UserId int,
	@name nvarchar(250),
	@status int = 1
AS
	INSERT INTO [ToDoItem] ([UserId], [Name], [Status]) 
	VALUES (@UserId, @name, @status)
RETURN 0
