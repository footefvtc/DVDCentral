BEGIN
	INSERT INTO tblMovie (Id, Title, Description, FormatId, DirectorId, RatingId, Cost, InStkQty, ImagePath)
	VALUES
	(1, 'Star Wars: The Force Awakens', 'Star Wars movie', 2, 1, 3, 10.00, 3, 'StarWars.jpg'),
	(2, 'The Breakfast Club', 'Teens and music', 1, 2, 4, 12.00, 5, 'BreakfastClub.jpg'),
	(3, 'Somewhere in Time', 'Romance and time travel', 3, 3, 2, 8.00, 4, 'SomewhereInTime.jpg')
END