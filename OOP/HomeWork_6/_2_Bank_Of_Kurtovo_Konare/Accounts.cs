namespace _2_Bank_Of_Kurtovo_Konare
{
    abstract class Accounts : Bank, IAccounts
    {
        private Customers customer;
        private decimal balance;
        private decimal interestRate;

        protected Accounts(Customers customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customers Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public decimal AddDeposit(decimal sum)
        {
            
           return this.Balance + sum;
           this.Balance += sum;
           
        }

        public virtual decimal CountingInterest(int period)
        {
            decimal result = this.Balance * (1 + (this.interestRate * 0.01m) * period);
            return result;
        }

        public override string ToString()
        {
            return "Customer: " + this.customer
                   + "\nBalance: " + this.balance
                   + "\nInterest rate: " + this.interestRate + "%";
        }
    }
}
