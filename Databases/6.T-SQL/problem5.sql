--Problem 5.	Add two more stored procedures 
--WithdrawMoney and DepositMoney.
--Add two more stored procedures 
--WithdrawMoney (AccountId, money) and 
--DepositMoney (AccountId, money) 
--that operate in transactions.

USE Bank

GO
CREATE PROC  usp_WithdrawMoney (@accountId INT, @money MONEY)
AS
BEGIN TRAN
DECLARE @currentBalance MONEY = ( SELECT
	a.Balance
FROM Accounts a
WHERE a.AccouuntID = @accountId)
IF (@currentBalance < @money) BEGIN
ROLLBACK TRAN
END ELSE BEGIN
UPDATE Accounts
SET Balance = @currentBalance - @money
WHERE AccouuntID = @accountId
COMMIT TRAN
END
GO
CREATE PROC  usp_DepositMoney (@accountId INT, @money MONEY)
AS
BEGIN TRAN
DECLARE @currentBalance MONEY = ( SELECT
	a.Balance
FROM Accounts a
WHERE a.AccouuntID = @accountId)
UPDATE Accounts
SET Balance = @currentBalance + @money
WHERE AccouuntID = @accountId
IF ((SELECT
	a.Balance
FROM Accounts a
WHERE a.AccouuntID = @accountId)
= @currentBalance + @money) BEGIN
COMMIT TRAN
END ELSE BEGIN
ROLLBACK TRAN
END
GO