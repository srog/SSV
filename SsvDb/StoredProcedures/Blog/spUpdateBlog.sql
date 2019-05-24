CREATE PROCEDURE [dbo].[spUpdateBlog]
	@id int,
	@name nvarchar(250)
AS
	UPDATE [Blog] 
	SET [Name] = @name
	WHERE [Id] = @id
RETURN 0
