//Problem 2.	Employee DAO Class
//Your task is to create a Data Access Object (DAO) class with static methods, which provide functionality for inserting, modifying and deleting employees. Write a testing class.

namespace DAOClass
{
    using System;

    using UsingDB;

    class DaoTestClass
    {
        static void Main()
        {
            var employee = new Employee
            {
                FirstName = "Georgi",
                MiddleName = "Georgiev",
                LastName = "Georgiev",
                HireDate = new DateTime(2001, 05, 12),
                JobTitle = "Programmer",
                DepartmentID = 1,
                Salary = 2560
            };

            // Step 1
            //var employeeId = DaoClass.InsertEmployee(employee);
            
            // Step 2
            //DaoClass.UpdateEmployeeSalaryByEmployeeId(employeeId, 6894);
            
            // Step 3
            //DaoClass.DeleteEmployeeById(employeeId);
        }
    }
}
