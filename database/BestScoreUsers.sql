CREATE TABLE [dbo].[BestScoreUsers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(MAX) NULL, 
    [BestScore] NVARCHAR(MAX) NULL
)
