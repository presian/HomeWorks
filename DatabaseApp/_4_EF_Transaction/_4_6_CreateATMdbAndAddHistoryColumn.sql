--Problem 4.	ATM Database
--Suppose you are creating a simple engine for an ATM machine. 
--Create a new database "ATM" in SQL Server to hold the accounts 
--of the cardholders and the balance (money) for each account. 
--Add a new table CardAccounts with the following fields:
--•	Id – int
--•	CardNumber – char(10)
--•	CardPIN – char(4)
--•	CardCash – money
--Add a few sample records in the table. Submit as solution the SQL script for your database.


--USE master
--GO
--CREATE DATABASE ATM

--USE ATM
--GO
--CREATE TABLE CardAccounts(
--Id INT PRIMARY KEY IDENTITY NOT NULL,
--CardNumber NVARCHAR(10) NOT NULL,
--CardPIN NVARCHAR(4) NOT NULL,
--CardCahs MONEY NOT NULL
--)

--USE ATM
--GO
--INSERT INTO CardAccounts(CardNumber, CardPIN, CardCahs)
--VALUES('BG99945678', '1598', 2546.25)

--INSERT INTO CardAccounts(CardNumber, CardPIN, CardCahs)
--VALUES('BG12435578', '2278', 1166.25)

--INSERT INTO CardAccounts(CardNumber, CardPIN, CardCahs)
--VALUES('BG11115678', '1338', 12546.25)

--INSERT INTO CardAccounts(CardNumber, CardPIN, CardCahs)
--VALUES('BG12664478', '9998', 8576.25)

--INSERT INTO CardAccounts(CardNumber, CardPIN, CardCahs)
--VALUES('BG22225678', '6958', 22594.25)


----Table for problem 6
--USE ATM
--GO
--CREATE TABLE TransactionHistory (
--Id INT PRIMARY KEY IDENTITY NOT NULL,
--CardNumber NVARCHAR(10) NOT NULL,
--TransactionDate DATETIME NOT NULL,
--Amount MONEY NOT NULL
--)