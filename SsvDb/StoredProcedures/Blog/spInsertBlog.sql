CREATE PROCEDURE [dbo].[spInsertBlog]
	@name nvarchar(250),
	@createdByUser int,
	@id int output
AS
DECLARE @result int
	INSERT INTO [Blog] ([Name], [Created], [CreatedByUser]) 
	VALUES (@name, GETDATE(), @createdByUser)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
