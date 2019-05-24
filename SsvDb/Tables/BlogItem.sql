CREATE TABLE [dbo].[BlogItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[BlogId] INT NOT NULL,
	[Created] DATETIME,
	[CreatedBy] NVARCHAR(250),
	[Text] NVARCHAR(MAX)
);
GO
CREATE INDEX idx_blogitem ON [BlogItem] ([BlogId])