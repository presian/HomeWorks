using System;

class QuotesInStrings
{
    static void Main()
    {
        string s = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(s);
        string st = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(st);
    }
}
