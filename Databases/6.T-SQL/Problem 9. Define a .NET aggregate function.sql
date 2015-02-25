-- More detailded description of this task you can find here
-- http://developmentsimplyput.blogspot.com/2013/03/creating-sql-custom-user-defined.html

--- Help instructions ---
--- Before run the script to create the aggregate function dbo.StrConcat
--- and after that test it you will need to ensure that the
--- ConcatenateStrings.dll has the correct location - in this case disk
--- C (you can specify another location as well)
--- Just copy the ConcatenateStrings.dll  to disk C

-- 1.FirstStep
-- Turning on CLR functionality
-- By default, CLR is disabled in SQL Server so to turn it on
-- we need to run this command against our database
EXEC sp_configure 'clr enabled', 1
GO
RECONFIGURE
GO

-- 2. SecondStep
-- Creating the SQL assembly and linking it to the C# library DLL
CREATE ASSEMBLY ConcatenateStrings
AUTHORIZATION dbo
FROM 'D:\SoftUni\HomeWork\Databases\6.T-SQL\ConcatenateStrings.dll' --- Please be sure that the dll file is here
WITH PERMISSION_SET = SAFE
GO
 
-- 3. ThirdStep
CREATE AGGREGATE dbo.StrConcat (@value nvarchar(MAX)) RETURNS nvarchar(MAX)
EXTERNAL NAME ConcatenateStrings.[ConcatenateStrings.StringConcatenator]
--EXTERNAL NAME SQLAssemblyName.[C#NameSpace".C#ClassName].C#MethodName

/*
DROP AGGREGATE dbo.StrConcat
DROP ASSEMBLY ConcatenateStrings
*/

USE SoftUni
SELECT dbo.StrConcat(FirstName + ' ' + LastName)
FROM Employees