using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter number n: ");
        uint number = uint.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= number; i++)
        {
            Console.Write("Please enter digit # {0}: ", i);
            double digit = double.Parse(Console.ReadLine());
            sum += digit;
        }
        Console.WriteLine("The sum is: " + sum);
    }
}
