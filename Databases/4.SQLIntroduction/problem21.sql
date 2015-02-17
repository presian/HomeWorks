SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
	 e.ManagerID,
	 m.FirstName + ' ' + m.LastName AS [Manager Name],
	 m.ManagerID,
	 a.AddressID,
	 a.AddressText,
	 a.TownID
FROM Employees e
	LEFT JOIN Employees m
		ON e.ManagerID = m.EmployeeID
	JOIN Addresses a
		on e.AddressID = a.AddressID
ORDER BY e.ManagerID