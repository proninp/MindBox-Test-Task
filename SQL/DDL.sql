CREATE TABLE [dbo].[Product](
	[Id] [int] NOT NULL  PRIMARY KEY,
	[Name] [nvarchar](250) NOT NULL
);

CREATE TABLE [dbo].[Product Category](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Name] [nvarchar](250) NOT NULL
);

CREATE TABLE [dbo].[Product Category Relation](
    [Product Id] INT,
    [Category Id] INT,
    PRIMARY KEY ([Product Id], [Category Id]),
    FOREIGN KEY ([Product Id]) REFERENCES [dbo].[Product]([Id]),
    FOREIGN KEY ([Category Id]) REFERENCES [Product Category]([Id])
);