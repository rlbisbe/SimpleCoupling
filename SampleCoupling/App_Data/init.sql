CREATE TABLE [dbo].[Table]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NULL, 
    [Author] NVARCHAR(50) NULL
)
INSERT INTO [dbo].[Table] (Title,Author) VALUES ('Hamlet', 'William Shakespeare')
INSERT INTO [dbo].[Table] (Title,Author) VALUES ('El Ingenioso Hidalgo Don Quijote de la Mancha', 'Miguel de Cervantes y Saavedra')
INSERT INTO [dbo].[Table] (Title,Author) VALUES ('La divina comedia', 'Dante Alighieri')
