CREATE PROCEDURE [dbo].[spGetBlogItem]
	@blogItemId int
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName' 
	FROM [BlogItem] b 
	INNER JOIN [User] u on u.[Id] = b.[CreatedByUser]
	WHERE b.[Id] = @blogItemId
RETURN 0