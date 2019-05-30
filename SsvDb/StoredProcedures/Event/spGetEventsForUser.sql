CREATE PROCEDURE [dbo].[spGetEventsForUser]
	@userId int
AS
	SELECT * FROM [Event] WHERE [UserId] = @userId OR [UserId] = 0
RETURN 0
