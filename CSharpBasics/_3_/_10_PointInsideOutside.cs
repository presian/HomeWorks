using System;

class PodecimalInsideOutside
{
    static void Main()
    {
        Console.Write("Please enter value for X: ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter value for Y: ");
        decimal y = decimal.Parse(Console.ReadLine());
        decimal r = 1.5m;
        bool inCircle = (((x - 1) * (x - 1)) + ((y - 1) * (y-1))) <= (r * r);
        if (inCircle && (y > 1))
	    {
            Console.WriteLine("YES");
	    }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
