SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
	 e.ManagerID,
	 m.FirstName + ' ' + m.LastName AS [Manager Name],
	 m.EmployeeID
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.EmployeeID
ORDER BY e.ManagerID