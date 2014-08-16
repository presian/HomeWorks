using System;

class Program
{
    static void Main()
    {
        // Input with check
        Console.Write("Please enter a number (n): ");
        double n = double.Parse(Console.ReadLine());
        if ((n < 1) || (n > 100))
        {
            Console.Write("Invalid number!!! Please try again, n = ");
            n = double.Parse(Console.ReadLine());
        }
        Console.Write("Please enter a number (k): ");
        double k = double.Parse(Console.ReadLine());
        if ((k < 1) || (k > 100))
        {
            Console.Write("Invalid number!!! Please try again, k = ");
            k = double.Parse(Console.ReadLine());
        }
        if (n < k)
        {
            Console.WriteLine("Number (n) must be bigger than (k)");
            Console.Write("Please try again!\n n = ");
            n = double.Parse(Console.ReadLine());
            Console.Write(" k = ");
            k = double.Parse(Console.ReadLine());
        }

        //Calculation

        double factorN = 1;
        double factorK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorN = factorN * i;
            if (i <= k)
            {
                factorK = factorK * i;
            }
        }
        double sum = factorN / factorK;
        Console.WriteLine(sum);
    }
}
