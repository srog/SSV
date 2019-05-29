CREATE PROCEDURE [dbo].[spGetBlog]
	@id int
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName'
	FROM [Blog] b 
	LEFT JOIN [User] u on u.Id = b.CreatedByUser
	WHERE b.[Id] = @id
RETURN 0
