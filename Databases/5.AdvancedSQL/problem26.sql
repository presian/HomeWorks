--Problem 26.	Write a SQL query to display 
--the minimal employee salary by department 
--and job title along with the name of 
--some of the employees that take it.

SELECT
	d.Name AS Department,
	e.JobTitle AS [Job Title],
	e.FirstName AS [First Name],
	e.Salary AS [Min Salary]
FROM Employees e
INNER JOIN Departments d
	ON d.DepartmentID = e.DepartmentID
GROUP BY	d.Name,
			e.JobTitle,
			e.FirstName,
			e.Salary,
			e.DepartmentID
HAVING e.Salary = (SELECT
	MIN(SALARY)
FROM Employees
WHERE DepartmentID = e.DepartmentID
AND e.JobTitle = JobTitle)