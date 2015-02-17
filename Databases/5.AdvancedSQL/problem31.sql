--Problem 31.	Define a table WorkHoursLogs to track all changes 
--in the WorkHours table with triggers.
--For each change keep the old record data, 
--the new record data and the command 
--(insert / update / delete).

CREATE TABLE WorkHoursLogs(
LogID INT IDENTITY PRIMARY KEY,
OldWorkHoursID INT,
OldEmployeeID INT,
OldWorkDate DATETIME,
OldTask NVARCHAR(500),
OldWorkHours INT,
OldComment NVARCHAR(500),
NewWorkHoursID INT,
NewEmployeeID INT,
NewWorkDate DATETIME,
NewTask NVARCHAR(500),
NewWorkHours INT,
NewComment NVARCHAR(500),
Command NVARCHAR(10) NOT NULL
)

CREATE TRIGGER tr_WorkHoursDelete ON WorkHours FOR DELETE
AS
BEGIN  
    INSERT INTO WorkHoursLogs
    SELECT 'DELETE', * , NULL, NULL, NULL, NULL, NULL, NULL
        FROM DELETED
END;
GO 

CREATE TRIGGER tr_WorkHoursUpdate ON WorkHours FOR UPDATE
AS
BEGIN  
    SET NOCOUNT ON;
    INSERT INTO WorkHoursLogs
    SELECT 'UPDATE',
               d.WorkHoursID,
                   d.WorkDate,
                   d.EmployeeID,
                   d.Task,
                   d.WorkHours,
                   d.Comments,
                   i.WorkHoursID,
                   i.WorkDate,
                   i.EmployeeID,
                   i.Task,
                   i.WorkHours,
                   i.Comments
        FROM INSERTED i, DELETED d
END;
GO

CREATE TRIGGER tr_WorkHoursInsert ON WorkHours FOR INSERT
AS
BEGIN  
    INSERT INTO WorkHoursLogs
    SELECT 'INSERT', NULL, NULL, NULL, NULL, NULL, NULL, *
        FROM INSERTED
END;