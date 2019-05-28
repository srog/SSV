CREATE PROCEDURE [dbo].[spInsertUser]
	@username nvarchar(250),
	@password nvarchar(20),
	@fullName nvarchar(250),
	@userType int,
	@isActive bit,
	@id int output
AS
DECLARE @result int
	INSERT INTO [User] ([Username], [Password], [Fullname], [UserType], [IsActive] )
	VALUES (@username, @password, @fullName, @userType, @isActive)
	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
