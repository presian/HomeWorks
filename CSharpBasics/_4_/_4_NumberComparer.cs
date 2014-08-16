using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Please enter number (a): ");
        decimal numberA = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter number (b): ");
        decimal numberB = decimal.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(numberA, numberB));            
    }
}
