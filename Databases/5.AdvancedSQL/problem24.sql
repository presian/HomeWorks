--Problem 24.	Write a SQL statement that 
--deletes all users without passwords (NULL password).

DELETE Users
WHERE UserPassword IS NULL