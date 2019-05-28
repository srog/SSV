CREATE PROCEDURE [dbo].[spUpdateUser]
	@username nvarchar(250),
	@password nvarchar(20),
	@fullName nvarchar(250),
	@userType int,
	@isActive bit,
	@id int output
	
AS
	UPDATE [User] 
	SET [Username] = @username,
		[Password] = @password,
		[Fullname] = @fullName,
		[UserType] = @userType,
		[IsActive] = @isActive
	WHERE [Id] = @id
RETURN 0
