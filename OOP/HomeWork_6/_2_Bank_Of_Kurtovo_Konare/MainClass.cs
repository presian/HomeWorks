using System;
using System.Collections.Generic;

namespace _2_Bank_Of_Kurtovo_Konare
{
    class MainClass
    {
        static void Main()
        {
            Deposit deposit1 = new Deposit(Customers.Individuals, 1500m, 2);
            Deposit deposit2 = new Deposit(Customers.Companies, 990m, 2);
            Loan loan1 = new Loan(Customers.Individuals, 1500m, 2);
            Loan loan2 = new Loan(Customers.Companies, 1500m, 2);
            Mortgage mortgage1 = new Mortgage(Customers.Individuals, 1500m, 2);
            Mortgage mortgage2 = new Mortgage(Customers.Companies, 1500m, 2);

            IList<Accounts> bankAccounts = new List<Accounts>();
            bankAccounts.Add(deposit1);
            bankAccounts.Add(deposit2);
            bankAccounts.Add(loan1);
            bankAccounts.Add(loan2);
            bankAccounts.Add(mortgage1);
            bankAccounts.Add(mortgage2);

            foreach (var bankAccount in bankAccounts)
            {
                Console.WriteLine("Type account: " + bankAccount.GetType().Name
                    + "\n" + bankAccount
                    + "\nTotal (after 13 month): " + bankAccount.CountingInterest(13)
                    + "\nTotal (after 5 month): " + bankAccount.CountingInterest(5) 
                    + "\nTotal after deposit (100): " + bankAccount.AddDeposit(100m) +"\n");
            }

            Console.WriteLine(deposit1 + "\nAfter withdraw (-100): " + deposit1.WithdrawMoney(100));
        }
    }
}
