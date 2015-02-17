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
DECLARE @firstName NVARCHAR(50), 
@lastName NVARCHAR(50), 
@town NVARCHAR(50) = '',
@fullName NVARCHAR(50) = '',
@currentTown NVARCHAR(50) = ''
FETCH NEXT FROM empCursor INTO @firstName, @lastName,  @town
WHILE @@FETCH_STATUS = 0
  BEGIN
	if @fullName = ''
	BEGIN
	SET @fullName = @firstName + ' ' + @lastName
	END
	SET @currentTown = @town
    PRINT @lastName + ': ' + @fullName + ' ' + @town + ' ' + @firstName
    FETCH NEXT FROM empCursor 
    INTO @firstName, @lastName, @town
	IF @currentTown <> @town
	BEGIN
		SET @fullName = ''
	END
  END
CLOSE empCursor
DEALLOCATE empCursor
