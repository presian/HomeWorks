--Problem 14.	Write a SQL query to display 
--the current date and time in the following format 
--"day.month.year hour:minutes:seconds:milliseconds".
SELECT
	CONVERT(VARCHAR, GETDATE(), 104) + ' ' + CONVERT(VARCHAR, GETDATE(), 114) AS [Date and Time]