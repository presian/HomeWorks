--Problem 30.	Issue few SQL statements to 
--insert, update and delete of some data in the table.

INSERT INTO WorkHours (EmployeeID, WorkDate, Task, WorkHours, Comments)
	VALUES (25, GETDATE(), 'Task 1', 5, 'Task_1_Commnet')
INSERT INTO WorkHours (EmployeeID, WorkDate, Task, WorkHours, Comments)
	VALUES (36, GETDATE(), 'Task 2', 6, 'Task_2_Commnet')

UPDATE WorkHours
SET WorkHours = 3
WHERE WorkHours = 5

DELETE WorkHours
WHERE Task = 'Task 2'
