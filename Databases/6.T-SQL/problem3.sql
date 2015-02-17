--Problem 3.Create a function with parameters
--Your task is to create a function that accepts as 
--parameters – sum, yearly interest rate and number of months. 
--It should calculate and return the new sum. 
--Write a SELECT to test whether the function works as expected.


USE Bank

GO
CREATE FUNCTION ufn_InterestCalculator 
	(@sum MONEY, @interest FLOAT, @monts FLOAT)
	RETURNS MONEY
AS
BEGIN
	RETURN (@sum * (@interest / 100)) * (@monts / 12)
END

GO

SELECT dbo.ufn_InterestCalculator(100, 20, 12) AS [Money]
