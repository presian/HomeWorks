--Problem 20.	Write SQL statements to 
--update some of the records in the Users and Groups tables.

UPDATE Users
SET FullName = 'Peter Ptrov'
WHERE UserName = 'Pesho'
UPDATE Users
SET FullName = 'Georgi Georgiev'
WHERE UserName = 'Gosho'
UPDATE Users
SET FullName = 'Alexander Alexandrov'
WHERE UserName = 'Alex'
UPDATE Users
SET FullName = 'Todor Todorv'
WHERE UserName = 'Tosho'
UPDATE Groups
SET Name = 'Snow'
WHERE Name = 'White'