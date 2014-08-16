using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Please insert positiv integer (2 - 100):");
        int n = int.Parse(Console.ReadLine());
        while ((n < 2) || (n > 100))
        {
            Console.WriteLine("Incorrect number. Please try again:");
            n = int.Parse(Console.ReadLine());
        }
        int counter = 1;
        bool prime = true;
        while (counter <= n)
        {
            if ((n % counter == 0) && (counter > 1) && (counter < n))
            {
                prime = false;
            }
            counter++;
        }
        Console.WriteLine("Is number prime? - {0}", prime);
    }
}
