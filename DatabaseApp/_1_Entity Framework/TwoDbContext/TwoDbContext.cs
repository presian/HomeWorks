//Problem 6.	Concurrent Database Changes with EF
//Your task is to try to open two different data contexts and to perform concurrent changes on the same records. What will happen at SaveChanges()? How to deal with it?

namespace TwoDbContext
{
    using System;
    using System.Linq;

    using UsingDB;

    class TwoDbContext
    {
        static void Main()
        {
            PrintActialData();
            OpenFirstConnection();
            PrintActialData();
        }

        private static void PrintActialData()
        {
            using (var db = new SoftUniEntities())
            {
                var employee = db.Employees.First();
                Console.WriteLine("Actual data in database: " + employee.FirstName + " " + employee.LastName);
            }
        }

        static void OpenFirstConnection()
        {
            using (var firstConnection = new SoftUniEntities())
            {
                PrntWhatFirstUserSees(firstConnection);
                OpenSecondConnection(firstConnection);
            }
        }

        private static void OpenSecondConnection(SoftUniEntities firstConnection)
        {
            using (var secondConnection = new SoftUniEntities())
            {
                PrintWhatSecondUserSees(firstConnection, secondConnection);
            }
        }

        private static void PrintWhatSecondUserSees(SoftUniEntities firstConnection, SoftUniEntities secondConnection)
        {
            var firstEmployee = secondConnection.Employees.First();
            Console.WriteLine("Second User see: " + firstEmployee.FirstName + " " + firstEmployee.LastName);
            firstEmployee.FirstName = "Tosho";
            Console.WriteLine("Second User change first name of employee to Tosho");
            firstConnection.SaveChanges();
            secondConnection.SaveChanges();
            PrintWhatFirstUserSeesAfterChange(firstConnection, secondConnection);
        }

        private static void PrintWhatFirstUserSeesAfterChange(SoftUniEntities firstConnection, SoftUniEntities secondConnection)
        {
            var firstEmployee = firstConnection.Employees.First();
            Console.WriteLine("First User see: " + firstEmployee.FirstName + " " + firstEmployee.LastName);
            PrintWhatSecondUserSeesAfterChange(secondConnection);
        }

        private static void PrintWhatSecondUserSeesAfterChange(SoftUniEntities secondConnection)
        {
            var firstEmployee = secondConnection.Employees.First();
            Console.WriteLine("Second User see: " + firstEmployee.FirstName + " " + firstEmployee.LastName);
        }

        private static void PrntWhatFirstUserSees(SoftUniEntities firstConnection)
        {
            var firstEmployee = firstConnection.Employees.First();
            Console.WriteLine("First User see: " + firstEmployee.FirstName + " " + firstEmployee.LastName );
            firstEmployee.FirstName = "Pesho";
            Console.WriteLine("First User change first name of employee to Pesho");
        }
    }
}
