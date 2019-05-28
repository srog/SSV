CREATE PROCEDURE [dbo].[spInsertBlogItem]
	@createdBy nvarchar(250),
	@blogId int,
	@text nvarchar(max),
	@id int output
AS
DECLARE @result int
	INSERT INTO [BlogItem] ([Created], [BlogId], [CreatedByUser], [Text])
	VALUES (GETDATE(), @blogId, @createdBy, @text)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result

