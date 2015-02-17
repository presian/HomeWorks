--Problem 29.	Write a SQL to create table WorkHours 
--to store work reports for each employee.
--Each employee should have id, date, task, hours and comments. 
--Don't forget to define identity, primary key 
--and appropriate foreign key.

CREATE TABLE WorkHours(
Id INT IDENTITY PRIMARY KEY,
EmployeeID INT FOREIGN KEY REFERENCES Employees(EmployeeID) NOT NULL,
WorkDate DATETIME,
Task NVARCHAR(500),
WorkHours INT,
Comments NVARCHAR(500)) 