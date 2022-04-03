CREATE TABLE [dbo].[Courses]
(
	[Id]		INT			NOT NULL PRIMARY KEY IDENTITY,
	[Name]		VARCHAR(25) NULL,
	[TeacherId]	INT			NOT NULL,
	[StartTime]	VARCHAR(4)	NULL,
	[EndTime]	VARCHAR(4)  NULL,
	[MaxSize]	INT			NOT NULL
	CONSTRAINT FK_Courses_Teachers FOREIGN KEY (TeacherId) REFERENCES Teachers (Id)
)
