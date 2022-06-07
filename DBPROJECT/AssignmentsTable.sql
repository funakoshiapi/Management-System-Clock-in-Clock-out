﻿CREATE TABLE [dbo].[AssignmentsTable]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [WorkerId] NVARCHAR(38) NOT NULL, 
    [BuildingId] NVARCHAR(38) NOT NULL, 
    [JobId] NVARCHAR(38) NOT NULL, 
    [DateAdded] DATETIME NOT NULL
)