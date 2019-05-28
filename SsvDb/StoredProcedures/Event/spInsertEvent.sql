CREATE PROCEDURE [dbo].[spInsertEvent]
	@name nvarchar(250),
	@description nvarchar(max),
	@userId int,
	@status int,
	@eventStart datetime = null,
	@eventEnd datetime = null,
	@location nvarchar(250),
	@isPublic bit,
	@id int output
AS
DECLARE @result int
	INSERT INTO [Event] ([Name], [Description], [UserId], [Status], [EventStart], [EventEnd], [Location], [IsPublic])
	VALUES (@name, @description, @userId, @status, @eventStart, @eventEnd, @location, @isPublic)
	
	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result