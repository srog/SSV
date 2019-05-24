CREATE PROCEDURE [dbo].[spUpdateBlogItem]
	@id int,
	@text nvarchar(max)
AS
	UPDATE [BlogItem] 
	SET [Text] = @text
	WHERE [Id] = @id
RETURN 0
