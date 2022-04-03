IF NOT EXISTS (SELECT TOP 1 * FROM Courses) 
BEGIN
	SET IDENTITY_INSERT Courses ON;

	INSERT INTO Courses (
		Id,
		Name,
		TeacherId,
		StartTime,
		EndTime,
		MaxSize
	)
	VALUES 
	(1, 'Math 101', 1, '1300', '1330', 25),
	(2, 'History 101', 2, '1100', '1200', 15),
	(3, 'Math 202', 3, '0800', '0830', 25),
	(4, 'Art 101', 4, '0900', '1000', 20)

	SET IDENTITY_INSERT Courses OFF;
END