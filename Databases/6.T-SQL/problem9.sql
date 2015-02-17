--Problem 9.	Define a .NET aggregate function
--Define a .NET aggregate function StrConcat 
--that takes as input a sequence of strings 
--and return a single string that 
--consists of the input strings separated by ','. 
--Example: SELECT StrConcat (FirstName + ' ' + LastName)
--			FROM Employees

USE SoftUni
GO

CREATE FUNCTION fn_StrConcat(@input NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN
DECLARE @strLen INT = LEN(@input)
DECLARE @index INT = 1
DECLARE @currentChar NVARCHAR(5) = ' '
DECLARE @result NVARCHAR(MAX) = ''
WHILE (@index <= @strLen)
BEGIN
SET @currentChar = SUBSTRING(@input, @index, 1)
IF @currentChar = ' ' 
BEGIN
	IF @index <> 1 AND @index <> @strLen
	BEGIN
	SET @currentChar = ', '
	END
END
SET @result = @result +	@currentChar
SET @index += 1
END
RETURN @result
END

GO

SELECT dbo.fn_StrConcat(FirstName + ' ' + LastName)
FROM Employees

GO