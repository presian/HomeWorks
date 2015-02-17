--Problem 17.	Write a SQL statement to create a table Groups. 
--Groups should have unique name (use unique constraint). 
--Define primary key and identity column.

CREATE TABLE Groups(
GroupID int IDENTITY PRIMARY KEY,
Name nvarchar(50) UNIQUE NOT NULL)
