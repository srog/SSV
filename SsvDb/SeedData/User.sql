
IF NOT EXISTS (SELECT * FROM [User]) 
BEGIN

INSERT INTO [User] ([Fullname], [Username], [Password], [UserType]) VALUES ('Admin User', 'admin', 'password1', 1)
INSERT INTO [User] ([Fullname], [Username], [Password], [UserType]) VALUES ('Guest', 'guest', '', 3)

END