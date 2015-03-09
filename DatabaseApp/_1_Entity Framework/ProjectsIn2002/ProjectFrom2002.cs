//Problem 3.	Write a method that finds employees with projects
//Your task is to write a method that finds all employees who have projects with start date in 2002 year.


namespace ProjectsIn2002
{
    using System;
    using System.Linq;

    using UsingDB;

    class ProjectFrom2002
    {
        static void Main()
        {
            EmployeesWithProjectsFrom2002();

        }

        static void EmployeesWithProjectsFrom2002()
        {
            var db = new SoftUniEntities();
            using (db)
            {
                var emp2002 = from e in db.Employees
                              where e.Projects.Any(p => p.StartDate >= new DateTime(2002, 1, 1)
                                                        && p.StartDate <= new DateTime(2002, 12, 31))
                              select e;

                foreach (var e in emp2002)
                {
                    Console.WriteLine(e.EmployeeID + " -> " + e.FirstName + ' ' + e.LastName);
                }
            }
        }   
    }
}
