//Problem 5.	Write a method that finds employees by department and manager
//Your task is to write a method that finds all employees by specified department (name) and manager (first name and last name).


namespace EmployeesByDepartmentAndManager
{
    using System;
    using System.Linq;

    using UsingDB;

    class EmployeesByDepartmentAndManager
    {
        static void Main()
        {
            EmployeesByDepartmentManager("Sales", "Stephen Jiang");
        }

        static void EmployeesByDepartmentManager(string deparmentName, string managerNames)
        {
            var db = new SoftUniEntities();
            using (db)
            {
                var employees = db.Employees.Where(
                    e => e.Department.Name == deparmentName && e.ManagerID == (
                        db.Employees.FirstOrDefault(
                            m => m.FirstName + " " + m.LastName == managerNames).EmployeeID));
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.FirstName + " " +
                        employee.LastName + " -> " +
                        employee.Department.Name + " => " +
                        managerNames);
                }
            }
        }
    }
}
