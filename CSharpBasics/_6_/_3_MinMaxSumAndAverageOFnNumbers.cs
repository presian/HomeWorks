using System;

class MinMaxSumAndAverageOFnNumbers
{
    static void Main()
    {
        Console.Write("Number (n):");
        int n = int.Parse(Console.ReadLine());
        if (n<1)
        {
            Console.WriteLine("Invalid number!!!");
            Console.Write("Try again! ");
            n = int.Parse(Console.ReadLine());
        }
        double sum = 0;
        int minNumber = int.MaxValue;
        int maxNumber = int.MinValue;
        double average = 0;
        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sum += num;
            minNumber = Math.Min(num, minNumber);
            maxNumber = Math.Max(num, maxNumber);
            average = sum / n;
        }
        Console.WriteLine("Min = " + minNumber);
        Console.WriteLine("Max = " + maxNumber);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Avg = {0:0.00}", average);
        
    }
}

