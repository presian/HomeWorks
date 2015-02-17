--Problem 34.	Find how to use temporary tables in SQL Server.
--Using temporary tables backup all records 
--from EmployeesProjects and restore them back 
--after dropping and re-creating the table.



SELECT * INTO #TempTableProjects
FROM EmployeesProjects;
 
 DROP TABLE EmployeesProjects;
 
 CREATE TABLE EmployeesProjects
  (
   EmployeeID INT FOREIGN KEY REFERENCES Employees(EmployeeID) NOT NULL,
   ProjectID INT FOREIGN KEY REFERENCES Projects(ProjectID) NOT NULL,
  );
 
 INSERT INTO EmployeesProjects
 SELECT * FROM  #TempTableProjects;
 
 DROP TABLE tempdb.#TempTableProjects;