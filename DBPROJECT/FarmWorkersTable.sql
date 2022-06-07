CREATE TABLE [dbo].[FarmWorkersTable]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(200) NOT NULL, 
    [LastName] NVARCHAR(200) NOT NULL, 
    [WorkerAccessCode] NVARCHAR(200) NOT NULL , 
    [DateAdded] DATETIME NOT NULL 
)
