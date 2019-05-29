
IF NOT EXISTS (SELECT * FROM [User]) 
BEGIN

INSERT INTO [User] ([Fullname], [Username], [Password], [UserType], [IsActive]) 
	VALUES ('Admin User', 'admin', 'password1', 1, 1)


END