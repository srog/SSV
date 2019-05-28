CREATE PROCEDURE [dbo].[spGetEventsForUser]
	@userId int
AS
	SELECT * FROM [Event] WHERE [UserId] = @userId
RETURN 0
