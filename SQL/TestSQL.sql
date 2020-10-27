CREATE DATABASE TestBase
GO

USE TestBase
GO


CREATE TABLE [Group](
	GroupID			INT PRIMARY KEY IDENTITY,
	Title			NVARCHAR(50) NOT NULL UNIQUE
)
GO


CREATE TABLE mainTable (
	ID				INT PRIMARY KEY IDENTITY,
	Title			NVARCHAR(50) NOT NULL,
	GroupID			INT NOT NULL REFERENCES [Group] (GroupID) ON UPDATE CASCADE,
	Size			INT NOT NULL,
	icon			VARBINARY(MAX) NULL
)
GO


INSERT INTO [Group] (Title)VALUES('Система')
INSERT INTO [Group] (Title)VALUES('Производительсность')
INSERT INTO [Group] (Title)VALUES('Медиа')
INSERT INTO [Group] (Title)VALUES('Работа')
INSERT INTO [Group] (Title)VALUES('Игры')
SELECT * FROM [Group]
GO


SELECT * FROM mainTable