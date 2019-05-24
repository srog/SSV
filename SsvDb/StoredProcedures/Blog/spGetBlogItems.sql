CREATE PROCEDURE [dbo].[spGetBlogItems]
	@blogId int
AS
	SELECT * FROM [BlogItem] WHERE [BlogId] = @blogId
RETURN 0
