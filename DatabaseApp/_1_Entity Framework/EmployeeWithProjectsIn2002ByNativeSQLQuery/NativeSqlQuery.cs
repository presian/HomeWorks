//Problem 4.	Implement previous by using native SQL query
//Your task is to solve the previous task by using native SQL query and executing it through the DbContext.


namespace EmployeeWithProjectsIn2002ByNativeSQLQuery
{
    using System;
    using System.Linq;

    using UsingDB;
    class NativeSqlQuery
    {
        static void Main()
        {
            AllEmployeeWithProjectsIn2002ByNativeSqlQuery();
        }

        static void AllEmployeeWithProjectsIn2002ByNativeSqlQuery()
        {
            var db = new SoftUniEntities();
            using (db)
            {
                var query =
                    "SELECT * FROM Employees e LEFT JOIN EmployeesProjects ep ON e.EmployeeID = ep.EmployeeID LEFT JOIN Projects p ON ep.ProjectID = p.ProjectID WHERE p.StartDate >= CONVERT(DATE, '01/01/2002', 104) AND p.StartDate <= CONVERT(DATE, '31/12/2002', 104)";
                var employees = db.Employees.SqlQuery(query).Distinct();
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.EmployeeID + " -> " + employee.FirstName + " " + employee.LastName);
                }
            }
        }
    }
}
