CREATE PROCEDURE [dbo].[spGetBlogItem]
	@blogItemId int
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName' 
	FROM [BlogItem] b 
	LEFT JOIN [User] u on u.[Id] = b.[CreatedByUser]
	WHERE b.[Id] = @blogItemId
RETURN 0