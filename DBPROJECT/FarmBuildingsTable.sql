﻿CREATE TABLE [dbo].[FarmBuildingsTable]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [BuildingTitle] NVARCHAR(300) NOT NULL, 
    [DateAdded] DATETIME NOT NULL
)
