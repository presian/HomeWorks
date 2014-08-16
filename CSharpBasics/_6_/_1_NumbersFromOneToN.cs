using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Please enter a number (n): ");
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            
        }
    }
}
