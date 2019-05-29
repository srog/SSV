CREATE PROCEDURE [dbo].[spInsertBlogItem]
	@createdByUser int,
	@blogId int,
	@text nvarchar(max),
	@id int output
AS
DECLARE @result int
	INSERT INTO [BlogItem] ([Created], [BlogId], [CreatedByUser], [Text])
	VALUES (GETDATE(), @blogId, @createdByUser, @text)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result

