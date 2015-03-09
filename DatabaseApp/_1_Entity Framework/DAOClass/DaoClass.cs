namespace DAOClass
{
    using UsingDB;

    class DaoClass
    {
        public static int InsertEmployee(Employee employee)
        {
            var db = new SoftUniEntities();
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee.EmployeeID;
        }

        public static int DeleteEmployeeById(int id)
        {
            var db = new SoftUniEntities();
            var employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return employee.EmployeeID;
        }

        public static int UpdateEmployeeSalaryByEmployeeId(int id, decimal newSalary)
        {
            var db = new SoftUniEntities();
            var employee = db.Employees.Find(id);
            employee.Salary = newSalary;
            db.SaveChanges();
            return employee.EmployeeID;
        }
    }
}
