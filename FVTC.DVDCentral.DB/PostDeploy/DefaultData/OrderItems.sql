BEGIN
	INSERT INTO tblOrderItem (Id, OrderId, Quantity, MovieId, Cost)
	VALUES
	(1, 1, 1, 1, 10.00),
	(2, 1, 1, 2, 12.00),
	(3, 2, 2, 3, 8.00),
	(4, 3, 1, 2, 12.00)
END