﻿CREATE PROCEDURE [dbo].[spGetAllBlogItems]

AS
	SELECT TOP 100 * FROM [BlogItem] ORDER BY [Id] DESC
RETURN 0