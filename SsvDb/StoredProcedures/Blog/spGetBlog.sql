CREATE PROCEDURE [dbo].[spGetBlog]
	@id int
AS
	SELECT * FROM [Blog] WHERE [Id] = @id
RETURN 0
