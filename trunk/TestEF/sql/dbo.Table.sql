CREATE TABLE [dbo].[t_student] 
(
	[Id] INT NOT NULL PRIMARY KEY,
	username	VARCHAR(100),
	loginname	VARCHAR(50),
	password	VARCHAR(100),
	sex	 CHAR(1), 
    [birthday] DATETIME NULL
)
