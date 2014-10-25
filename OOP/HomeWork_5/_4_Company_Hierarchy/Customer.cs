using System;

namespace _4_Company_Hierarchy
{
    class Customer : Person, ICustomer
    {
        private decimal customerAmount;

        public Customer(string firstName, string lastName, long id, decimal customerAmount)
            : base(firstName, lastName, id)
        {
            this.CustomerAmount = customerAmount;
        }

        public decimal CustomerAmount
        {
            get
            {
                return this.customerAmount;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The sum that customer spent for product cannot be zero or negative");
                }
                this.customerAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()+"\nCustomer amount: " + this.customerAmount;
        }
    }
}
