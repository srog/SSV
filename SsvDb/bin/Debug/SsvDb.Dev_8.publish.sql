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


IF NOT EXISTS (SELECT * FROM [User]) 
BEGIN

INSERT INTO [User] ([Fullname], [Username], [Password], [UserType]) VALUES ('Admin User', 'admin', 'password1', 1)
INSERT INTO [User] ([Fullname], [Username], [Password], [UserType]) VALUES ('Guest', 'guest', '', 3)

END
GO

GO
PRINT N'Altering [dbo].[spGetBlog]...';


GO
ALTER PROCEDURE [dbo].[spGetBlog]
	@id int
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName'
	FROM [Blog] b 
	LEFT JOIN [User] u on u.Id = b.CreatedByUser
	WHERE b.[Id] = @id
RETURN 0
GO
PRINT N'Altering [dbo].[spGetBlogItem]...';


GO
ALTER PROCEDURE [dbo].[spGetBlogItem]
	@blogItemId int
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName' 
	FROM [BlogItem] b 
	LEFT JOIN [User] u on u.[Id] = b.[CreatedByUser]
	WHERE b.[Id] = @blogItemId
RETURN 0
GO
PRINT N'Update complete.';


GO
