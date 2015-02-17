--Problem 16.	Write a SQL statement to create a view that displays the users 
--from the Users table that have been in the system today.

CREATE VIEW [Today's Users] AS
SELECT
	u.UserName,
	u.LastLoginActivity
FROM Users u
WHERE CONVERT(NVARCHAR(10), u.LastLoginActivity, 104) = CONVERT(NVARCHAR(10), GETDATE(), 104)