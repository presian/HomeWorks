using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Please enter number - a (integer, 0 - 500):");
        int numberA = int.Parse(Console.ReadLine());
        Console.Write("Please enter floating-point number - b:");
        float numberB = float.Parse(Console.ReadLine());
        Console.Write("Please enter floating-point number - c:");
        float numberC = float.Parse(Console.ReadLine());
        string convertA = Convert.ToString(numberA, 2).PadLeft(10, '0');
        Console.WriteLine("{0, -10:X} | {1, 10} | {2, 10:F2} | {3, -10:F3}", numberA, convertA, numberB, numberC);
            
    }
}
