CREATE PROCEDURE [dbo].[spInsertRating]
	@entityId int,
	@userId int,
	@ratingValue int,
	@ratingText nvarchar(max)
AS
DECLARE @result int

	INSERT INTO [Rating] ([EntityId], [Created], [UserId], [RatingValue], [RatingText])
	VALUES (@entityId, GETDATE(), @userId, @ratingValue, @ratingText)

	
	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
