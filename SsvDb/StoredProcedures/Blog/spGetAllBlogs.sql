CREATE PROCEDURE [dbo].[spGetAllBlogs]
	
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName' 
	FROM [Blog] b
	LEFT JOIN [User] u on u.Id = b.CreatedByUser
RETURN 0
