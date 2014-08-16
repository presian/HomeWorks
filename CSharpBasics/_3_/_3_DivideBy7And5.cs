using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Please enter integer:");
        int i = int.Parse(Console.ReadLine());
        bool dividable = (i % 5 == 0) && (i % 7 == 0);
        Console.WriteLine(dividable);
    }
}
