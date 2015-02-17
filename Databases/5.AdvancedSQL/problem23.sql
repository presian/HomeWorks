--Problem 23.	Write a SQL statement that changes 
--the password to NULL for all users 
--that have not been in the system since 10.03.2010.

ALTER TABLE Users
ALTER COLUMN UserPassword NVARCHAR(50) NULL

UPDATE Users
SET LastLoginActivity = CONVERT(NVARCHAR, '9.3.2010', 104)
WHERE UserID IN (123, 15, 45)

UPDATE Users
SET UserPassword = NULL
WHERE LastLoginActivity < CONVERT(NVARCHAR, '10.3.2010', 104)