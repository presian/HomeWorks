using System;
using System.Collections.Generic;

namespace _4_Company_Hierarchy
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private IList<Sale> salesOfEmployee;

        public SalesEmployee(string firstName, string lastName, long id, decimal salary, Department department, IList<Sale> salesOfEmployee)
            : base(firstName, lastName, id, salary, department)
        {
            this.SalesOfEmployee = salesOfEmployee;
        }

        public IList<Sale> SalesOfEmployee
        {
            get
            {
                return this.salesOfEmployee;
            }
            set
            {
                if (value.Count < 1)
                {
                    throw new ArgumentException("The list of sales cannot be empty");
                }
                this.salesOfEmployee = value;
            }
        }

        public override string ToString()
        {
            string allsales = string.Empty;
            foreach (var sale in salesOfEmployee)
            {
                allsales += sale;
            }
            return base.ToString();
        }
    }
}
