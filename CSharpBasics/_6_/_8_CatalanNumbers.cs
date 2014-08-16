using System;

    class CatalanNumbers
    {
        static void Main()
        {
            // Input with check
            Console.Write("Please enter a number (1 < n < 100): ");
            double n = double.Parse(Console.ReadLine());
            if ((n < 0) || (n > 100))
            {
                Console.Write("Invalid number!!! Please try again, n = ");
                n = double.Parse(Console.ReadLine());
            }
            double nBy2 = n * 2;
            double nPlus1 = n + 1;
            double factorN = 1;
            double factorN_By2 = 1;
            double factorN_Plus1 = 1;
            for (int i = 1; i <= nBy2; i++)
            {
                factorN_By2 = factorN_By2 * i;
                if (i <= nPlus1)
                {
                    factorN_Plus1 = factorN_Plus1 * i;
                }
                if (i <= n)
                {
                    factorN = factorN * i;
                }
            }
            double sum = factorN_By2 / (factorN_Plus1 * factorN);
            Console.WriteLine(sum);
        }
    }
