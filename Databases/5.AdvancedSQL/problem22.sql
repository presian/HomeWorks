--Problem 22.	Write SQL statements to insert 
--in the Users table the names of 
--all employees from the Employees table.
--Combine the first and last names as a full name. 
--For username use the first letter of the first name + 
--the last name (in lowercase). 
--Use the same for the password, and NULL for last login time.


ALTER TABLE Users
ALTER COLUMN LastLoginActivity datetime NULL
INSERT INTO Users
SELECT
	e.FirstName + ' ' + e.LastName AS FullName,
	SUBSTRING (e.FirstName, 1, 1) + LOWER(e.LastName) AS UserName,
	SUBSTRING (e.FirstName, 1, 1) + LOWER(e.LastName) AS UserPassword,
	NULL AS LastLoginActivity,
	NULL AS GroupID
FROM Employees e
