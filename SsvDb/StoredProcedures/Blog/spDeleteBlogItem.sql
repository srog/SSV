CREATE PROCEDURE [dbo].[spDeleteBlogItem]
	@id int
AS
	DELETE FROM [BlogItem] WHERE [Id] = @id
RETURN 0
