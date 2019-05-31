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
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--:r .\SeedData\User.sql
GO

GO
PRINT N'Rename refactoring operation with key eefc0c09-d410-4096-a89c-7bfa69111f84 is skipped, element [dbo].[ToDoItem].[Completed] (SqlSimpleColumn) will not be renamed to Status';


GO
PRINT N'Creating [dbo].[ToDoItem]...';


GO
CREATE TABLE [dbo].[ToDoItem] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (250) NOT NULL,
    [UserId] INT            NOT NULL,
    [Status] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Altering [dbo].[spGetEventsForUser]...';


GO
ALTER PROCEDURE [dbo].[spGetEventsForUser]
	@userId int
AS
	SELECT * FROM [Event] WHERE [UserId] = @userId OR [UserId] = 0
RETURN 0
GO
PRINT N'Creating [dbo].[spGetToDoItem]...';


GO
CREATE PROCEDURE [dbo].[spGetToDoItem]
	@id int
AS
	SELECT * FROM [ToDoItem] WHERE [Id] = @id
RETURN 0
GO
PRINT N'Creating [dbo].[spGetToDoItems]...';


GO
CREATE PROCEDURE [dbo].[spGetToDoItems]
	@userId int
AS
	SELECT * FROM [ToDoItem] WHERE [UserId] = @userId
RETURN 0
GO
PRINT N'Creating [dbo].[spInsertToDoItem]...';


GO
CREATE PROCEDURE [dbo].[spInsertToDoItem]
	@UserId int,
	@name nvarchar(250),
	@status int = 1
AS
	INSERT INTO [ToDoItem] ([UserId], [Name], [Status]) 
	VALUES (@UserId, @name, @status)
RETURN 0
GO
PRINT N'Creating [dbo].[spUpdateToDoItem]...';


GO
CREATE PROCEDURE [dbo].[spUpdateToDoItem]
	@id int,
	@userId int,
	@name nvarchar(250),
	@status int
AS
	UPDATE [ToDoItem] SET [Status] = @status, [Name] = @name 
	WHERE [Id] = @id
RETURN 0
GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'eefc0c09-d410-4096-a89c-7bfa69111f84')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('eefc0c09-d410-4096-a89c-7bfa69111f84')

GO

GO
PRINT N'Update complete.';


GO