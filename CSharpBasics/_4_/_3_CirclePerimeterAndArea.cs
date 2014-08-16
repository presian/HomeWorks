using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter radius (r): ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double perimeter = 2 * pi * radius;
        Console.WriteLine("Perimeter of the circle is: {0:F2}", perimeter);
        double area = pi * radius * radius;
        Console.WriteLine("Area of the circle is: {0:F2}",area);
    }
}
