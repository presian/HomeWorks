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


            var employeeId = DaoClass.InsertEmployee(employee);
            //DaoClass.UpdateEmployeeSalaryByEmployeeId(employeeId, 6894);
            //DaoClass.DeleteEmployeeById(employeeId);
        }
    }
}
