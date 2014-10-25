using System;

namespace _4_Company_Hierarchy
{
    class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public Employee(string firstName, string lastName, long id, decimal salary, Department department) : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value<=0)
                {
                    throw new Exception("The employee cannot work for free");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nDepartment: " + this.department + "\nSalary: " + this.salary;
        }
    }
}
