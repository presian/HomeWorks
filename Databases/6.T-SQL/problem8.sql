--Problem 8.	Using database cursor write a T-SQL.
--Using database cursor write a T-SQL script 
--that scans all employees and their addresses 
--and prints all pairs of employees that live in the same town.
USE SoftUni
GO

DECLARE empCursor CURSOR READ_ONLY FOR SELECT
	e.FirstName,
	e.LastName,
	t.Name AS Town
FROM Employees e
INNER JOIN Addresses a
	ON a.AddressID = e.AddressID
INNER JOIN Towns t
	ON t.TownID = a.TownID

OPEN empCursor
DECLARE @firstName NVARCHAR(MAX), 
@lastName NVARCHAR(MAX), 
@town NVARCHAR(MAX) = ''
FETCH NEXT FROM empCursor INTO 
	@firstName, 
	@lastName,  
	@town
WHILE @@FETCH_STATUS = 0
  BEGIN
	DECLARE innerEmpCursor CURSOR READ_ONLY FOR
	SELECT e.FirstName, e.LastName, t.Name
	FROM Employees e
	INNER JOIN Addresses a
		ON a.AddressID = e.AddressID
	INNER JOIN Towns t
		ON a.TownID = t.TownID
	WHERE t.Name = @town
	ORDER BY a.AddressID
	OPEN innerEmpCursor
	DECLARE @innerFirstName NVARCHAR(MAX), 
	@innerLastName NVARCHAR(MAX),
	@innerTown NVARCHAR(MAX)
	FETCH NEXT FROM innerEmpCursor INTO 
		@innerFirstName, 
		@innerLastName, 
		@innerTown
		WHILE @@FETCH_STATUS = 0
			BEGIN
			PRINT @innerLastName + ': ' 
				+ @firstName + ' ' 
				+ @lastName + ' ' 
				+ @town + ' ' 
				+ @innerLastName
			FETCH NEXT FROM innerEmpCursor 
			INTO @innerLastName, 
				@innerLastName, 
				@innerTown
		END
	CLOSE innerEmpCursor
	DEALLOCATE innerEmpCursor
	FETCH NEXT FROM empCursor 
	INTO @firstName, 
		@lastName, 
		@town
  END
CLOSE empCursor
DEALLOCATE empCursor