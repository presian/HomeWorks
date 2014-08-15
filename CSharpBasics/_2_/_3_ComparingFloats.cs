using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Please enter first floating-point number:");
        decimal d = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter second floating-point number:");
        decimal dl = decimal.Parse(Console.ReadLine());
        if (Math.Abs(d - dl) < 0.000001m)
        {
            Console.WriteLine("Numbers are equal (true)!");
        }
        else
        {
            Console.WriteLine("Numbers are not equal (false)!");
        }
    }
}
