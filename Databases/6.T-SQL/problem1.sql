--Problem 1.	Create a database with two tables
--Persons (id (PK), first name, last name, SSN) and 
--Accounts (id (PK), person id (FK), balance). 
--Insert few records for testing. 
--Write a stored procedure that selects the full names of all persons.
USE Bank
GO

CREATE TABLE Persons(
PersonID INT IDENTITY PRIMARY KEY NOT NULL,
FirstName NVARCHAR(20) NOT NULL,
LastName NVARCHAR(20) NOT NULL,
SSN NVARCHAR(20) NOT NULL)

GO

CREATE TABLE Accounts(
AccouuntID INT IDENTITY PRIMARY KEY NOT NULL,
PersonID INT FOREIGN KEY REFERENCES Persons(PersonID) NOT NULL,
Balance MONEY NOT NULL)

GO

INSERT INTO Persons (FirstName, LastName, SSN)
	VALUES ('Peter', 'Petrov', '8801011263')
INSERT INTO Persons (FirstName, LastName, SSN)
	VALUES ('Georgi', 'Georgiev', '8602021591')
INSERT INTO Persons (FirstName, LastName, SSN)
	VALUES ('Todor', 'Todorov', '8104119601')

INSERT INTO Accounts (PersonID, Balance)
	VALUES (1, 3654.125)
INSERT INTO Accounts (PersonID, Balance)
	VALUES (1, 12.125)
INSERT INTO Accounts (PersonID, Balance)
	VALUES (2, 8994.125)
INSERT INTO Accounts (PersonID, Balance)
	VALUES (2, 11125.125)
INSERT INTO Accounts (PersonID, Balance)
	VALUES (3, 6666589.125)

GO

CREATE PROC usp_SelectPersonsFullName
AS
SELECT FirstName + ' ' + LastName AS [Full Name]
FROM Persons

GO

EXEC usp_SelectPersonsFullName