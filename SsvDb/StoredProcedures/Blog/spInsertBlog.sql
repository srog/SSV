CREATE PROCEDURE [dbo].[spInsertBlog]
	@name nvarchar(250),
	@createdBy nvarchar(250),
	@id int output
AS
DECLARE @result int
	INSERT INTO [Blog] ([Name], [Created], [CreatedByUser]) 
	VALUES (@name, GETDATE(), @createdBy)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
