SELECT  e.FirstName + ' ' + e.LastName AS [Full Name],
	e.HireDate,
	d.Name
FROM Employees e, Departments d
WHERE e.HireDate BETWEEN '1.1.1995' AND '1.1.2005' 
	AND e.DepartmentID = d.DepartmentID 
	AND d.Name IN ('Sales', 'Finance')