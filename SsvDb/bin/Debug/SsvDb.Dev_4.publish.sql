﻿/*
Deployment script for SSV

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "SSV"
:setvar DefaultFilePrefix "SSV"
:setvar DefaultDataPath "D:\Programs\MSSQL14.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "D:\Programs\MSSQL14.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
The column [dbo].[BlogItem].[Name] is being dropped, data loss could occur.
*/

IF EXISTS (select top 1 1 from [dbo].[BlogItem])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Altering [dbo].[BlogItem]...';


GO
ALTER TABLE [dbo].[BlogItem] DROP COLUMN [Name];


GO
PRINT N'Altering [dbo].[spInsertBlogItem]...';


GO
ALTER PROCEDURE [dbo].[spInsertBlogItem]
	@createdBy nvarchar(250),
	@blogId int,
	@text nvarchar(max),
	@id int output
AS
DECLARE @result int
	INSERT INTO [BlogItem] ([Created], [BlogId], [CreatedBy], [Text])
	VALUES (GETDATE(), @blogId, @createdBy, @text)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
GO
PRINT N'Refreshing [dbo].[spDeleteBlogItem]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spDeleteBlogItem]';


GO
PRINT N'Refreshing [dbo].[spGetBlogItems]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spGetBlogItems]';


GO
PRINT N'Refreshing [dbo].[spUpdateBlogItem]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spUpdateBlogItem]';


GO
PRINT N'Update complete.';


GO