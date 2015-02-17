--Problem 27.	Write a SQL query to display the town 
--where maximal number of employees work.

SELECT TOP 1
	t.Name AS [Town],
	COUNT(*) AS [Number of employees]
FROM Employees e
INNER JOIN Addresses a
	ON e.AddressID = a.AddressID
INNER JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Number of employees] DESC