--Problem 11.	Write a SQL query to find 
--all managers that have exactly 5 employees.
SELECT m.FirstName, m.LastName, COUNT(e.EmployeeID) AS [Employees count]
FROM Employees m
	INNER JOIN Employees e
		ON m.EmployeeID = e.ManagerID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(e.EmployeeID) = 5