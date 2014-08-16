using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Please enter number (a): ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter number (b): ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please enter number (c): ");
        double numberC = double.Parse(Console.ReadLine());
        double discrim = (numberB * numberB) - (4 * numberA * numberC);
        Console.WriteLine("The discriminant is: {0}", discrim);
        double xOne;
        double xTwo;
        double xOnly;
        if (discrim > 0 )
        {
            xOne = ((-numberB) + Math.Sqrt(discrim)) / (2 * numberA);
            Console.WriteLine("Root #1 = {0}",xOne);
            xTwo = ((-numberB) - (Math.Sqrt(discrim))) / (2 * numberA);
            Console.WriteLine("Root #2 = {0}", xTwo);
        }
        if (discrim < 0)
        {
            Console.WriteLine("No real roots!");
        }
        if (discrim == 0)
        {
            xOnly = (-numberB) / (2 * numberA);
            Console.WriteLine("Root is only one = {0}", xOnly);
        }  
    }
}
