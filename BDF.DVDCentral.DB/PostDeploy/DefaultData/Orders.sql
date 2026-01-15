BEGIN
	INSERT INTO tblOrder (Id, CustomerId, OrderDate, ShipDate, UserId)
	VALUES
	(1, 1, '2023-08-05', '2023-08-10', 1),
	(2, 2, '2023-08-25', '2023-08-30', 2),
	(3, 3, '2023-09-02', '2023-09-15', 1)
END