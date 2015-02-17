--Problem 28.	Write a SQL query to display 
--the number of managers from each town.

SELECT
	t.Name AS [Town],
	count(*) AS [Number of Managers]
FROM Employees e
	INNER JOIN Addresses a
		ON a.AddressID = e.AddressID
	INNER JOIN Towns t
		ON t.TownID = a.TownID
WHERE e.EmployeeID IN (SELECT DISTINCT
	ManagerID
FROM Employees)
GROUP BY t.Name
ORDER BY t.Name