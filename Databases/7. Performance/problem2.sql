--USE [PerformanceTunings]
--GO
--CREATE NONCLUSTERED INDEX [ByDate]
--ON [dbo].[ThenMils] ([RecordDate])
--INCLUDE ([RecordId],[Record])
--GO
--CHECKPOINT; DBCC DROPCLEANBUFFERS;
SELECT RecordId, RecordDate, Record
FROM ThenMils WITH(INDEX(ByDate))
WHERE RecordDate < DATEADD(YEAR,3,GETDATE()) 
	AND RecordDate > DATEADD(YEAR,-3,GETDATE())
GO