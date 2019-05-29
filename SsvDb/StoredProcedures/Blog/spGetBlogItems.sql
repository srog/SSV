CREATE PROCEDURE [dbo].[spGetBlogItems]
	@blogId int
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName' 
	FROM [BlogItem] b 
	LEFT JOIN [User] u on u.[Id] = b.[CreatedByUser] 
	WHERE [BlogId] = @blogId
RETURN 0
