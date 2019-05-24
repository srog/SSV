CREATE PROCEDURE [dbo].[spDeleteBlog]
	@id int
AS
	DELETE FROM [Blog] WHERE [Id] = @id
RETURN 0
