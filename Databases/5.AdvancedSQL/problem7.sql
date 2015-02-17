--Problem 7.	Write a SQL query to find 
--the number of all employees that have manager.
SELECT
	COUNT(e.ManagerID) AS [Employees with manager]
FROM Employees e