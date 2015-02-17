USE Bank

GO

CREATE PROC usp_PeopleWithMoreMoney(@money MONEY)
AS
SELECT
	p.FirstName + ' ' + p.LastName AS [Name],
	a.Balance
FROM Persons p
INNER JOIN Accounts a
	ON a.PersonID = p.PersonID
WHERE a.Balance >= @money

GO

EXEC usp_PeopleWithMoreMoney @money = 11125.125