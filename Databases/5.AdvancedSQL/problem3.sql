SELECT
	e.FirstName + ' ' + e.LastName AS Name,
	e.Salary,
	d.Name AS DepartmentName
FROM Employees e
	JOIN Departments d
		ON d.DepartmentID = e.DepartmentID
WHERE e.Salary = (SELECT
	MIN(Salary)
FROM Employees emp
WHERE e.DepartmentID = emp.DepartmentID)