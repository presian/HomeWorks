namespace _2_Bank_Of_Kurtovo_Konare
{
    class Loan : Accounts
    {
        public Loan(Customers customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CountingInterest(int period)
        {
            if (this.Customer==Customers.Individuals)
            {
                period -=3;
                if (period<0)
                {
                    period = 0;
                }
            } else if (this.Customer==Customers.Companies)
            {
                period -=2;
                if (period < 0)
                {
                    period = 0;
                }
            }
            decimal result = this.Balance * (1 + (this.InterestRate * 0.01m) * period);
            return result;
        }
    }
}
