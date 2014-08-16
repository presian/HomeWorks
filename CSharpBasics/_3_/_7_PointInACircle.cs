using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Please insert value for X:");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please insert value for Y:");
        decimal y = decimal.Parse(Console.ReadLine());
        byte r = 2;
        bool inCircle = ((x * x) + (y * y) <= (r * r));
        Console.WriteLine(inCircle);
    }
}
