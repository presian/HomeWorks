using System;
using System.Collections.Generic;

namespace _4_Company_Hierarchy
{
    class Manager : Employee, IManager
    {
        private IList<Employee> menagedEmployees;

        public Manager(string firstName, string lastName, long id, decimal salary, Department department, IList<Employee> menagedEmployees)
            : base(firstName, lastName, id, salary, department)
        {
            this.MenagedEmployees = menagedEmployees;
        }

        public IList<Employee> MenagedEmployees
        {
            get
            {
                return this.menagedEmployees;
            }
            set
            {
                this.menagedEmployees = value;
            }
        }

        public override string ToString()
        {
            List<String> employeeToPrint=new List<string>();
            foreach (var menagedEmployee in menagedEmployees)
            {
                employeeToPrint.Add(menagedEmployee.FirstName + " " + menagedEmployee.LastName);
            }
            string toPrint = string.Join(", ", employeeToPrint);
            return base.ToString() + "\nManaged employee: " + toPrint + ";";
        }
    }
}
