using System;

namespace _2_Human_Students_Worker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public Worker(string firstName, string lastName, decimal weekSalery, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalery = weekSalery;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalery
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("We cannot work without money");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Cannot work 0 hours per day if we have a job");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result = this.weekSalary / 5 / (decimal)this.workHoursPerDay;
            return result;
        }
    }
}
