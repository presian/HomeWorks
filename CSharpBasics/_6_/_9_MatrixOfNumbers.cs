using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Please enter a positive integer number n (1 <= n <= 20): ");
            int n = int.Parse(Console.ReadLine());
            if ((n < 1) || (n > 20))
            {
                Console.Write("Invalid number. The number must be integer, bigger than 1 and smaller than 20!!!\nPlease try again: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < row + n; col++)
                {

                    Console.Write(col + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
