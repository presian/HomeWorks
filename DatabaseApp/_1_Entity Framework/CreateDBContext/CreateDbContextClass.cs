// Problem 1.	DbContext for the SoftUni Database
// Your task is to create a DbContext for the SoftUni database using the Visual Studio Entity Framework Designer

namespace CreateDBContext
{
    using System;
    using System.Linq;

    using UsingDB;

    class CreateDbContextClass
    {
        static void Main(string[] args)
        {
            var db = new SoftUniEntities();
            var employees = db.Employees.ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
        }
    }
}
