USE SoftUni
GO

DECLARE townCursor CURSOR READ_ONLY FOR
SELECT t.Name
FROM Towns t
ORDER BY t.Name DESC
OPEN townCursor
DECLARE @town NVARCHAR(MAX),
@empNames NVARCHAR(MAX)
FETCH NEXT FROM townCursor INTO @town
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @empNames = ''
		DECLARE empCursor CURSOR READ_ONLY FOR
		SELECT e.FirstName + ' ' + e.LastName
		FROM Employees e
			INNER JOIN Addresses a
				ON a.AddressID = e.AddressID
			INNER JOIN Towns t
				ON t.TownID = a.TownID
		WHERE t.Name = @town
		OPEN empCursor
		DECLARE @empName NVARCHAR(MAX)
		FETCH NEXT FROM empCursor INTO @empName
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF @empNames <> ''
			BEGIN
				SET @empNames = @empNames + ', ' + @empName
			END
			ELSE
			BEGIN
				SET @empNames = @empName 
			END
			FETCH NEXT FROM empCursor INTO @empName
		END
		PRINT @town + '->' + @empNames
		CLOSE empCursor
		DEALLOCATE empCursor
		FETCH NEXT FROM townCursor INTO @town
	END
CLOSE townCursor
DEALLOCATE townCursor
