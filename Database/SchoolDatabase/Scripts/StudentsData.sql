IF NOT EXISTS (SELECT TOP 1 * FROM Students) 
BEGIN
	INSERT INTO Students (
		FirstName,
		LastName,
		DOB,
		Sex
	)
	VALUES
	('John', 'Smith', '19951004', 'M'),
	('Mac', 'Mittereder', '19951227', 'M'),
	('Haleigh', 'Mittereder', '19950307', 'F'),
	('Jane', 'Doe', '19950107', 'F')
END