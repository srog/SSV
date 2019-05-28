CREATE PROCEDURE [dbo].[spGetUser]
	@id int
AS
	SELECT * FROM [User] WHERE [Id] = @id
RETURN 0
