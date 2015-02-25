USE PerformanceTunings
GO

--CREATE TABLE ThenMils(
--RecordId INT PRIMARY KEY IDENTITY NOT NULL,
--RecordDate DATE NOT NULL,
--Record NVARCHAR(5) NOT NULL
--)
--GO

--DECLARE @index INT = 5000000,
--@today DATETIME = GETDATE()
--WHILE @index > 0
--BEGIN
--	INSERT INTO ThenMils(RecordDate, Record) 
--	VALUES (DATEADD(MINUTE,-@index,@today), 'abc')
--	INSERT INTO ThenMils(RecordDate, Record) 
--	VALUES (DATEADD(MINUTE,@index,@today), 'abcd')
--	SET @index = @index - 1
--END

CHECKPOINT; DBCC DROPCLEANBUFFERS;
SELECT RecordId, RecordDate, Record
FROM ThenMils
WHERE RecordDate < DATEADD(YEAR,3,GETDATE()) 
	AND RecordDate > DATEADD(YEAR,-3,GETDATE())
