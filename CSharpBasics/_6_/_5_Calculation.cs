using System;
//using System.Numerics;

class Calculation
{
    static void Main()
    {
        Console.Write("Number (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Number (x): ");
        int x = int.Parse(Console.ReadLine());
        int factor = 1;
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            factor = factor * i;
            sum += (factor / (Math.Pow(x, i)));
        }
        Console.WriteLine("The result is: {0:F5}", sum + 1);
    }
}

