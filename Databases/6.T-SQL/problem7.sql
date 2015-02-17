--Problem 7.	Define function in the SoftUni database.
--Define a function in the database SoftUni 
--that returns all Employee's names (first or middle or last name) 
--and all town's names that are comprised of given set of letters. 
--Example: 'oistmiahf' will return 'Sofia', 'Smith', 
--but not 'Rob' and 'Guy'.

USE SoftUni
GO

CREATE FUNCTION fn_StringFuzzyComparator
(@name NVARCHAR(MAX), @str NVARCHAR(MAX))
RETURNS bit
AS
BEGIN
	DECLARE @strLen INT = LEN(@str)
	DECLARE @nameLen INT = LEN(@name)
	DECLARE @index INT = 1
	DECLARE @currentChar NVARCHAR(1) = ''
	DECLARE @matchCounter INT = 0
	IF @nameLen > @strLen
	BEGIN
		RETURN 0
	END
 
	WHILE (@index <= @nameLen)
	BEGIN
SET @currentChar = SUBSTRING(@name, @index, 1)
IF @str NOT LIKE '%' + @currentChar + '%' BEGIN
RETURN 0
END
SET @index += 1
END
RETURN 1
END
GO

CREATE FUNCTION fn_NameResearcher (@letters nvarchar(MAX))
RETURNS @tbl_AllNamesFromLetters TABLE	(
NameID INT PRIMARY KEY IDENTITY NOT NULL,
Name NVARCHAR(MAX) NOT NULL)
AS
BEGIN
DECLARE @a table(
Id int primary key identity not null,
Name nvarchar(max))
INSERT INTO @a (Name)
	SELECT
		FirstName
	FROM Employees

INSERT INTO @a (Name)
	SELECT
		LastName AS Name
	FROM Employees

INSERT INTO @a (Name)
	SELECT
		MiddleName AS Name
	FROM Employees
	WHERE MiddleName IS NOT NULL

INSERT INTO @a (Name)
	SELECT
		Name AS Name
	FROM Towns
INSERT @tbl_AllNamesFromLetters
	SELECT DISTINCT
		Name
	FROM @a currentName
	WHERE 1 = dbo.fn_StringFuzzyComparator(currentName.Name, @letters)
RETURN
END
GO

SELECT
	*
FROM fn_NameResearcher('oistmiahf')

GO