namespace _2_Bank_Of_Kurtovo_Konare
{
    class Mortgage : Accounts
    {
        public Mortgage(Customers customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CountingInterest(int period)
        {
            if (this.Customer == Customers.Individuals)
            {
                decimal result = this.Balance
                    * (1 + (this.InterestRate * 0.01m * (period - 6)) + ((this.InterestRate * 0.01m / 2.0m) * 6));
                return result;
            }
            else
            {
                decimal result = this.Balance
                    * (1 + (this.InterestRate * 0.01m * (period - 12)) + ((this.InterestRate * 0.01m / 2.0m) * 12));
                return result;
            }
        }
    }
}
