using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        decimal balance = 35648.36m;
        string bankName = "DSK";
        string iBAN = "BG65 BNBG 9661 3100 1665 01";
        ulong firstCardNumber = 5976481672348265;
        ulong secondCardNumber = 7394628493165936;
        ulong thirdcardNumber = 9567183492765419;
        Console.WriteLine(
            "Bank Account Data:\n Name:{0} {1} {2}\n Balance:{3}\n Bankname:{4}\n IBAN:{5}\n First Credit Card:{6}\n Second Credit Card:{7}\n Third Credit Card:{8}",
            firstName, middleName, lastName, balance, bankName, iBAN, firstCardNumber,secondCardNumber, thirdcardNumber);
    }
}

