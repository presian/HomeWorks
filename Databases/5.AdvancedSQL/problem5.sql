SELECT
	AVG(Salary) AS [Average Salary IN Sales Department]
FROM Employees e
INNER JOIN Departments d
	ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'
