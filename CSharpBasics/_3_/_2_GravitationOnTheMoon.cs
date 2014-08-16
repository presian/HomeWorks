using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Please insert your weight (kg):");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("Your weight on the Moon is:{0}kg",weightOnMoon);
    }
}
