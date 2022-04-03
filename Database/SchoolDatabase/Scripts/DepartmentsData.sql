IF NOT EXISTS (SELECT TOP 1 * FROM Departments)
BEGIN
	SET IDENTITY_INSERT Departments ON;

	INSERT INTO Departments ( 
		Id,
		Name
	)
	VALUES 
	(1, 'Math'),
	(2, 'History'),
	(3, 'Art')

	SET IDENTITY_INSERT Departments OFF;
END 