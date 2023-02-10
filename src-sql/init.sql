CREATE DATABASE [Mindbox.TestTask.Sql];

GO

CREATE TABLE [Mindbox.TestTask.Sql].[dbo].[Products] (
	Id BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(200) NOT NULL
);

CREATE TABLE [Mindbox.TestTask.Sql].[dbo].[Categories] (
	Id BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(200) NOT NULL
);

CREATE TABLE [Mindbox.TestTask.Sql].[dbo].[ProductCategories] (
	ProductId BIGINT NOT NULL REFERENCES Products(Id),
	CategoryId BIGINT NOT NULL REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

GO

INSERT INTO [Mindbox.TestTask.Sql].[dbo].[Products] (Name) VALUES 
('Продукт 1'),
('Продукт 2'),
('Продукт 3');

INSERT INTO [Mindbox.TestTask.Sql].[dbo].[Categories] (Name) VALUES 
('Категория 1'),
('Категория 2');

INSERT INTO [Mindbox.TestTask.Sql].[dbo].[ProductCategories] (ProductId, CategoryId) VALUES 
(1, 1),
(1, 2),
(2, 1);