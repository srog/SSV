CREATE PROCEDURE [dbo].[spUpdateUser]
	@username nvarchar(250),
	@password nvarchar(20),
	@fullName nvarchar(250),
	@userType int,
	@isActive bit,
	@email nvarchar(250),
	@id int output
	
AS
	UPDATE [User] 
	SET [Username] = @username,
		[Password] = @password,
		[Fullname] = @fullName,
		[UserType] = @userType,
		[Email] = @email,
		[IsActive] = @isActive
	WHERE [Id] = @id
RETURN 0
