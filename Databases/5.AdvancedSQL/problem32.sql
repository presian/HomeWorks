--Problem 32.	Start a database transaction, 
--delete all employees from the 'Sales' department 
--along with all dependent records from the pother tables. 
--At the end rollback the transaction.
BEGIN TRAN
DELETE Employees
WHERE DepartmentID = (SELECT
		d.DepartmentID
	FROM Departments d
	WHERE d.Name = 'Sales')
ROLLBACK TRAN