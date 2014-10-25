namespace _2_Bank_Of_Kurtovo_Konare
{
    class Deposit : Accounts
    {
        public Deposit(Customers customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public decimal WithdrawMoney(decimal sum)
        {
            return this.Balance - sum;
            this.Balance -= sum;
        }
        public override decimal CountingInterest(int period)
        {
            if (this.Balance>=1000)
            {
                return base.CountingInterest(period);
            }
            else
            {
                return this.Balance;
            }
        }
    }
}
