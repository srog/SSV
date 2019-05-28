CREATE PROCEDURE [dbo].[spGetAllBlogs]
	
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName' 
	FROM [Blog] b
	INNER JOIN [User] u on u.Id = b.CreatedByUser
RETURN 0
