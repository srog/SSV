CREATE PROCEDURE [dbo].[spInsertEntity]
	@name nvarchar(250),
	@entityType int,
		@id int output
AS
DECLARE @result int
	INSERT INTO [Entity] ([Name], [Created], [EntityType])
	VALUES (@name, GETDATE(), @entityType)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result