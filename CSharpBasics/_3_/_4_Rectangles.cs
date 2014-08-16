using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please enter height:");
        decimal height = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter width:");
        decimal width = decimal.Parse(Console.ReadLine());
        decimal perimeter = (width + height) * 2;
        decimal area = width * height;
        Console.WriteLine("Parameter: {0}\nArea: {1}", perimeter, area);
    }
}
