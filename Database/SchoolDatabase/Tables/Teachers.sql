CREATE TABLE [dbo].[Teachers]
(
	[Id]			INT			NOT NULL PRIMARY KEY IDENTITY,
	[FirstName]		VARCHAR(25) NULL,
	[LastName]		VARCHAR(25) NULL,
	[DOB]			DATETIME	NULL,
	[Sex]			CHAR(1)		NULL,
	[DepartmentId]	INT			NULL
	CONSTRAINT FK_Teachers_Departments FOREIGN KEY (DepartmentId) REFERENCES Departments (Id)
)
