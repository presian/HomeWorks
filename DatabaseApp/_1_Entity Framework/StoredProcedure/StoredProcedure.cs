//Problem 10.	Create a stored procedures in the SoftUni database
//Your task is to create a stored procedures in the SoftUni database for finding the total projects for given employee first name and last name. Implement a C# method that calls the stored procedure and returns the retuned record set.

namespace StoredProcedure
{

    using System;
    using System.Linq;
    using UsingDB;

    class StoredProcedure
    {
        static void Main()
        {
            //First must execute StoredProc.sql to create procedure in DB
            CallStoreProcedure("Gay", "Gilbert");
        }

        static void CallStoreProcedure(string firstName, string lastName)
        {
            using (var db = new SoftUniEntities())
            {
                var projectCount = db.usp_ProjectsOfEmployee(firstName, lastName).Single();
                Console.WriteLine(string.Format("{0} {1} has {2} projects!", firstName, lastName, projectCount));
            }
        }
    }
}
