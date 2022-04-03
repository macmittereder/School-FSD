IF NOT EXISTS (SELECT TOP 1 * FROM Teachers) 
BEGIN
	SET IDENTITY_INSERT Teachers ON;

	INSERT INTO Teachers (
		Id,
		FirstName,
		LastName,
		DOB,
		Sex,
		DepartmentId
	)
	VALUES 
	(1, 'John', 'Doe', '19800305', 'M', 1),
	(2, 'Jason', 'Smith', '19790912', 'M', 2),
	(3, 'Nikki', 'Crane', '19220818', 'F', 1),
	(4, 'Carol', 'Flynn', '19811109', 'F', 3)
	
	SET IDENTITY_INSERT Teachers OFF;
END 