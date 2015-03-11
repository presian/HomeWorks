namespace TransactionalATMWithdrawal
{
    using System;
    using System.Linq;

    class AtmClient
    {
        static void Main()
        {
            // Valid transaction
//            Withdraw("BG99945678", "1598", 200.25m);

            // Invalid transaction - wrong card data
//            Withdraw("BG9456654678", "1598", 200.25m);

            // Invalid transaction - not enaught money in account
//            Withdraw("BG99945678", "1598", 2222222200.25m);
        }

        private static void Withdraw(string cardNumber, string cardPin, decimal amount)
        {
            var db = new ATMEntities();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var account = GetAccountIfCardDataIsValid(db, cardPin, cardNumber);
                    CheckAccountHasEnoughMoney(account, amount);
                    account.CardCahs = account.CardCahs - amount;
                    
// Problem 6.	ATM Transactions History
// Extend the project from the previous exercise and add a new table TransactionHistory with fields (Id, CardNumber, TransactionDate, Amount) holding information about all money withdrawals on all accounts.
// Modify the withdrawal logic so that it preserves history in the new table after each successful money withdrawal.
                    db.TransactionHistories.Add(new TransactionHistory
                    {
                        Amount = amount,
                        CardNumber = cardNumber,
                        TransactionDate = DateTime.Now
                    });
                    db.SaveChanges();
                    tran.Commit();
                    Console.WriteLine("Transaction compleat!");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void CheckAccountHasEnoughMoney(CardAccount account, decimal amount)
        {
            if (account.CardCahs <= amount)
            {
                throw new InvalidOperationException("Not enaught money in acount!");
            }
        }

        private static CardAccount GetAccountIfCardDataIsValid(ATMEntities db, string cardPin, string cardNumber)
        {
            try
            {
                var result = db.CardAccounts.Single(a => a.CardPIN == cardPin && a.CardNumber == cardNumber);
                return result;
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Wrong cardPin and cardNumber pair!");
            }
        }
    }
}
