--Problem 4.	Create a stored procedure that uses the function 
--from the previous example.
--Your task is to create a stored procedure 
--that uses the function from the previous example 
--to give an interest to a person's account for one month. 
--It should take the AccountId and the interest rate as parameters.

USE Bank

GO
CREATE PROC usp_InterestOverAccounts
@accountId int, @rate FLOAT
AS

SELECT
	AccouuntID,
	a.Balance,
	dbo.ufn_InterestCalculator(a.Balance, @rate, 1) AS [Interest]
FROM Accounts a
WHERE a.AccouuntID = @accountId
GO

EXEC dbo.usp_InterestOverAccounts 1, 20