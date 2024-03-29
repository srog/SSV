﻿/*
Deployment script for ssv

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "ssv"
:setvar DefaultFilePrefix "ssv"
:setvar DefaultDataPath "C:\Users\s.rogers\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"
:setvar DefaultLogPath "C:\Users\s.rogers\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"

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
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET TEMPORAL_HISTORY_RETENTION ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


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
PRINT N'Creating [dbo].[Blog]...';


GO
CREATE TABLE [dbo].[Blog] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (250) NULL,
    [Created]       DATETIME       NULL,
    [CreatedByUser] INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[BlogItem]...';


GO
CREATE TABLE [dbo].[BlogItem] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [BlogId]        INT            NOT NULL,
    [Created]       DATETIME       NULL,
    [CreatedByUser] INT            NULL,
    [Text]          NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[BlogItem].[idx_blogitem]...';


GO
CREATE NONCLUSTERED INDEX [idx_blogitem]
    ON [dbo].[BlogItem]([BlogId] ASC);


GO
PRINT N'Creating [dbo].[Entity]...';


GO
CREATE TABLE [dbo].[Entity] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (250) NULL,
    [Created]    DATETIME       NULL,
    [EntityType] INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Event]...';


GO
CREATE TABLE [dbo].[Event] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [UserId]      INT            NOT NULL,
    [IsPublic]    BIT            NOT NULL,
    [Name]        NVARCHAR (250) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [EventStart]  DATETIME       NULL,
    [EventEnd]    DATETIME       NULL,
    [Location]    NVARCHAR (250) NULL,
    [Status]      INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Movie]...';


GO
CREATE TABLE [dbo].[Movie] (
    [EntityId]      INT            NOT NULL,
    [Name]          NVARCHAR (250) NULL,
    [ImageFilePath] NVARCHAR (250) NULL,
    [ImdbLink]      NVARCHAR (250) NULL,
    [ImdbRating]    DECIMAL (18)   NULL,
    [YearReleased]  INT            NULL,
    PRIMARY KEY CLUSTERED ([EntityId] ASC)
);


GO
PRINT N'Creating [dbo].[Music]...';


GO
CREATE TABLE [dbo].[Music] (
    [EntityId]      INT            NOT NULL,
    [Name]          NVARCHAR (250) NULL,
    [ImageFilePath] NVARCHAR (250) NULL,
    [SpotifyLink]   NVARCHAR (250) NULL,
    [YearReleased]  INT            NULL,
    PRIMARY KEY CLUSTERED ([EntityId] ASC)
);


GO
PRINT N'Creating [dbo].[Rating]...';


GO
CREATE TABLE [dbo].[Rating] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [EntityId]    INT            NOT NULL,
    [Created]     DATETIME       NULL,
    [UserId]      INT            NULL,
    [RatingValue] INT            NULL,
    [RatingText]  NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[User]...';


GO
CREATE TABLE [dbo].[User] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Fullname] NVARCHAR (250) NULL,
    [Username] NVARCHAR (250) NULL,
    [Password] NVARCHAR (20)  NULL,
    [UserType] INT            NOT NULL,
    [IsActive] BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[spDeleteBlog]...';


GO
CREATE PROCEDURE [dbo].[spDeleteBlog]
	@id int
AS
	DELETE FROM [Blog] WHERE [Id] = @id
RETURN 0
GO
PRINT N'Creating [dbo].[spDeleteBlogItem]...';


GO
CREATE PROCEDURE [dbo].[spDeleteBlogItem]
	@id int
AS
	DELETE FROM [BlogItem] WHERE [Id] = @id
RETURN 0
GO
PRINT N'Creating [dbo].[spDeleteEvent]...';


GO
CREATE PROCEDURE [dbo].[spDeleteEvent]
	@id int

AS
	DELETE FROM [Event] WHERE [Id] = @id
RETURN 0
GO
PRINT N'Creating [dbo].[spGetAllBlogItems]...';


GO
CREATE PROCEDURE [dbo].[spGetAllBlogItems]

AS
	SELECT TOP 100 * FROM [BlogItem] ORDER BY [Id] DESC
RETURN 0
GO
PRINT N'Creating [dbo].[spGetAllBlogs]...';


GO
CREATE PROCEDURE [dbo].[spGetAllBlogs]
	
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName' 
	FROM [Blog] b
	LEFT JOIN [User] u on u.Id = b.CreatedByUser
RETURN 0
GO
PRINT N'Creating [dbo].[spGetAllEntities]...';


GO
CREATE PROCEDURE [dbo].[spGetAllEntities]
AS
	SELECT * FROM [Entity]
RETURN 0
GO
PRINT N'Creating [dbo].[spGetAllEvents]...';


GO
CREATE PROCEDURE [dbo].[spGetAllEvents]

AS
	SELECT * FROM [Event]
RETURN 0
GO
PRINT N'Creating [dbo].[spGetAllMovies]...';


GO
CREATE PROCEDURE [dbo].[spGetAllMovies]

AS
	SELECT * FROM [Entity] WHERE [EntityType] = 1
RETURN 0
GO
PRINT N'Creating [dbo].[spGetAllMusic]...';


GO
CREATE PROCEDURE [dbo].[spGetAllMusic]

AS
	SELECT * FROM [Entity] WHERE [EntityType] = 2
RETURN 0
GO
PRINT N'Creating [dbo].[spGetAllUsers]...';


GO
CREATE PROCEDURE [dbo].[spGetAllUsers]
AS
	SELECT * FROM [User]
RETURN 0
GO
PRINT N'Creating [dbo].[spGetBlog]...';


GO
CREATE PROCEDURE [dbo].[spGetBlog]
	@id int
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName'
	FROM [Blog] b 
	LEFT JOIN [User] u on u.Id = b.CreatedByUser
	WHERE b.[Id] = @id
RETURN 0
GO
PRINT N'Creating [dbo].[spGetBlogItem]...';


GO
CREATE PROCEDURE [dbo].[spGetBlogItem]
	@blogItemId int
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName' 
	FROM [BlogItem] b 
	LEFT JOIN [User] u on u.[Id] = b.[CreatedByUser]
	WHERE b.[Id] = @blogItemId
RETURN 0
GO
PRINT N'Creating [dbo].[spGetBlogItems]...';


GO
CREATE PROCEDURE [dbo].[spGetBlogItems]
	@blogId int
AS
	SELECT b.*, u.Fullname AS 'CreatedByFullName' 
	FROM [BlogItem] b 
	LEFT JOIN [User] u on u.[Id] = b.[CreatedByUser] 
	WHERE [BlogId] = @blogId
RETURN 0
GO
PRINT N'Creating [dbo].[spGetEvent]...';


GO
CREATE PROCEDURE [dbo].[spGetEvent]
	@id int 
AS
	SELECT * FROM [Event] WHERE [Id] = @id
RETURN 0
GO
PRINT N'Creating [dbo].[spGetEventsForUser]...';


GO
CREATE PROCEDURE [dbo].[spGetEventsForUser]
	@userId int
AS
	SELECT * FROM [Event] WHERE [UserId] = @userId
RETURN 0
GO
PRINT N'Creating [dbo].[spGetMovieDetails]...';


GO
CREATE PROCEDURE [dbo].[spGetMovieDetails]
	@entityId int
AS
	SELECT * FROM [Movie] WHERE [EntityId] = @entityId
RETURN 0
GO
PRINT N'Creating [dbo].[spGetMusicDetails]...';


GO
CREATE PROCEDURE [dbo].[spGetMusicDetails]
	@entityId int
AS
	SELECT * FROM [Music] WHERE [EntityId] = @entityId
RETURN 0
GO
PRINT N'Creating [dbo].[spGetRatingsForEntity]...';


GO
CREATE PROCEDURE [dbo].[spGetRatingsForEntity]
	@entityId int
AS
	SELECT * FROM [Rating] WHERE [EntityId] = @entityId
RETURN 0
GO
PRINT N'Creating [dbo].[spGetUser]...';


GO
CREATE PROCEDURE [dbo].[spGetUser]
	@id int
AS
	SELECT * FROM [User] WHERE [Id] = @id
RETURN 0
GO
PRINT N'Creating [dbo].[spInsertBlog]...';


GO
CREATE PROCEDURE [dbo].[spInsertBlog]
	@name nvarchar(250),
	@createdByUser int,
	@id int output
AS
DECLARE @result int
	INSERT INTO [Blog] ([Name], [Created], [CreatedByUser]) 
	VALUES (@name, GETDATE(), @createdByUser)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
GO
PRINT N'Creating [dbo].[spInsertBlogItem]...';


GO
CREATE PROCEDURE [dbo].[spInsertBlogItem]
	@createdByUser int,
	@blogId int,
	@text nvarchar(max),
	@id int output
AS
DECLARE @result int
	INSERT INTO [BlogItem] ([Created], [BlogId], [CreatedByUser], [Text])
	VALUES (GETDATE(), @blogId, @createdByUser, @text)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
GO
PRINT N'Creating [dbo].[spInsertEntity]...';


GO
CREATE PROCEDURE [dbo].[spInsertEntity]
	@name nvarchar(250),
	@entityType int,
		@id int output
AS
DECLARE @result int
	INSERT INTO [Entity] ([Name], [Created], [EntityType])
	VALUES (@name, GETDATE(), @entityType)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
GO
PRINT N'Creating [dbo].[spInsertEvent]...';


GO
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
GO
PRINT N'Creating [dbo].[spInsertMovie]...';


GO
CREATE PROCEDURE [dbo].[spInsertMovie]
	@entityId int,
	@name nvarchar(250),
	@imageFilePath nvarchar(250),
	@imdbLink nvarchar(250),
	@imdbRating decimal,
	@yearReleased int,
	@id int output
AS
DECLARE @result int

	INSERT INTO [Movie] ([EntityId], [Name], [ImageFilePath], [ImdbLink], [ImdbRating], [YearReleased])
	VALUES (@entityId, @name, @imageFilePath, @imdbLink, @imdbRating, @yearReleased)


	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
GO
PRINT N'Creating [dbo].[spInsertMusic]...';


GO
CREATE PROCEDURE [dbo].[spInsertMusic]
	@entityId int,
	@name nvarchar(250),
	@imageFilePath nvarchar(250),
	@spotifyLink nvarchar(250),
	@yearReleased int,
	@id int output
AS
	DECLARE @result int

	INSERT INTO [Music] ([EntityId], [Name], [ImageFilePath], [SpotifyLink], [YearReleased])
	VALUES (@entityId, @name, @imageFilePath, @spotifyLink, @yearReleased)

	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
GO
PRINT N'Creating [dbo].[spInsertRating]...';


GO
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
GO
PRINT N'Creating [dbo].[spInsertUser]...';


GO
CREATE PROCEDURE [dbo].[spInsertUser]
	@username nvarchar(250),
	@password nvarchar(20),
	@fullName nvarchar(250),
	@userType int,
	@isActive bit,
	@id int output
AS
DECLARE @result int
	INSERT INTO [User] ([Username], [Password], [Fullname], [UserType], [IsActive] )
	VALUES (@username, @password, @fullName, @userType, @isActive)
	SET @id = SCOPE_IDENTITY()

	SET @result  = @@ERROR  
	SELECT @result

	RETURN @result
GO
PRINT N'Creating [dbo].[spUpdateBlog]...';


GO
CREATE PROCEDURE [dbo].[spUpdateBlog]
	@id int,
	@name nvarchar(250)
AS
	UPDATE [Blog] 
	SET [Name] = @name
	WHERE [Id] = @id
RETURN 0
GO
PRINT N'Creating [dbo].[spUpdateBlogItem]...';


GO
CREATE PROCEDURE [dbo].[spUpdateBlogItem]
	@id int,
	@text nvarchar(max)
AS
	UPDATE [BlogItem] 
	SET [Text] = @text
	WHERE [Id] = @id
RETURN 0
GO
PRINT N'Creating [dbo].[spUpdateEvent]...';


GO
CREATE PROCEDURE [dbo].[spUpdateEvent]
	@id int,
	@status int
AS
	UPDATE [Event] SET [Status] = @status WHERE [Id] = @id
RETURN 0
GO
PRINT N'Creating [dbo].[spUpdateUser]...';


GO
CREATE PROCEDURE [dbo].[spUpdateUser]
	@username nvarchar(250),
	@password nvarchar(20),
	@fullName nvarchar(250),
	@userType int,
	@isActive bit,
	@id int output
	
AS
	UPDATE [User] 
	SET [Username] = @username,
		[Password] = @password,
		[Fullname] = @fullName,
		[UserType] = @userType,
		[IsActive] = @isActive
	WHERE [Id] = @id
RETURN 0
GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
