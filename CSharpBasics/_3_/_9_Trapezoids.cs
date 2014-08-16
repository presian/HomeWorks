using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Please enter length of side A: ");
        decimal sideA = decimal.Parse(Console.ReadLine());
        while ((sideA <= 0))
        {
            Console.WriteLine("Incorrect number. Please try again:");
            sideA = decimal.Parse(Console.ReadLine());
        }
        Console.Write("Please enter length of side B: ");
        decimal sideB = decimal.Parse(Console.ReadLine());
        while ((sideB <= 0))
        {
            Console.WriteLine("Incorrect number. Please try again:");
            sideB = decimal.Parse(Console.ReadLine());
        }
        Console.Write("Please enter length of height H: ");
        decimal heightH = decimal.Parse(Console.ReadLine());
        while ((heightH <= 0))
        {
            Console.WriteLine("Incorrect number. Please try again:");
            heightH = decimal.Parse(Console.ReadLine());
        }
        decimal area = ((sideA + sideB)/2) * heightH;
        Console.WriteLine( area);
    }
}
