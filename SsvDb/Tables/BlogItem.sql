CREATE TABLE [dbo].[BlogItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[BlogId] INT NOT NULL,
	[Created] DATETIME,
	[CreatedByUser] INT,
	[Text] NVARCHAR(MAX)
);
GO
CREATE INDEX idx_blogitem ON [BlogItem] ([BlogId])