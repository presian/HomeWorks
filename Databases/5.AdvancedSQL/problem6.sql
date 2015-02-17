--Problem 6.Write a SQL query to find 
--the number of employees in the "Sales" department.
SELECT COUNT(e.EmployeeID) AS [Employee COUNT IN Sales Dep]
FROM Employees e
	INNER JOIN Departments d
		ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'