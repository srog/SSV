
IF EXISTS (SELECT [object_id] FROM sys.objects WHERE [name] = 'User' AND [type] = 'U')
BEGIN

	IF NOT EXISTS (SELECT * FROM [User]) 
	BEGIN

	INSERT INTO [User] ([Fullname], [Username], [Password], [UserType], [IsActive], [Email]) 
		VALUES ('Admin User', 'admin', 'password1', 1, 1, 'wellwater@hotmail.co.uk')

	END
END
