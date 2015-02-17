SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
	 e.ManagerID,
	 m.FirstName + ' ' + m.LastName AS [Manager Name],
	 m.EmployeeID,
	 a.AddressText,
	 a.TownID,
	 a.AddressID
FROM Employees e
	LEFT OUTER JOIN Employees m
		ON e.ManagerID = m.EmployeeID
	JOIN Addresses a
		ON e.AddressID = a.AddressID
ORDER BY e.ManagerID