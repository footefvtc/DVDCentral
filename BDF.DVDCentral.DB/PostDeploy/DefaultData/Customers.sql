BEGIN
	INSERT INTO tblCustomer (Id, FirstName, LastName, UserId, Address, City, State, Zip, Phone)
	VALUES
	(1, 'Ken', 'Adams', 1, '6610 Mifflin Ave', 'Harrisburg', 'PA', '17111', '9203791234'),
	(2, 'Mary Kay', 'Jones', 2, '758 Cherry St', 'Appleton', 'WI','54912', '9208478956'),
	(3, 'Betty', 'Cooper', 1, '109 Peach Ave', 'Menasha', 'WI','54952', '9204657594')
END