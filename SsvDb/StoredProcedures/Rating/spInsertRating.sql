CREATE PROCEDURE [dbo].[spInsertRating]
	@entityId int,
	@userId int,
	@ratingValue int,
	@ratingText nvarchar(max)
AS
	INSERT INTO [Rating] ([EntityId], [Created], [UserId], [RatingValue], [RatingText])
	VALUES (@entityId, GETDATE(), @userId, @ratingValue, @ratingText)
RETURN 0
