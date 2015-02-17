--Problem 25.	Write a SQL query to 
--display the average employee salary 
--by department and job title.

SELECT e.JobTitle, d.Name, AVG(Salary) AS [Average Salary]
FROM Employees e
	INNER JOIN Departments d
		ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY e.JobTitle