--Problem 10.	Write a SQL query to find 
--the count of all employees in each department and for each town.

SELECT t.Name AS Town, d.Name AS Department, COUNT(*) AS [Employees count]
FROM Employees e
	INNER JOIN Departments d
		ON d.DepartmentID = e.DepartmentID
	INNER JOIN Addresses a
		ON a.AddressID = e.AddressID
	INNER JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY t.Name, d.Name