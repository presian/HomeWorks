namespace _2_Bank_Of_Kurtovo_Konare
{
    interface IAccounts
    {
        Customers Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }

        decimal AddDeposit(decimal sum);
        decimal CountingInterest(int period);
    }
}
