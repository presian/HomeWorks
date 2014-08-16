using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please enter third number: ");
        double numberC = double.Parse(Console.ReadLine());
        if ((numberA >= numberB) && (numberA >= numberC))
        {
            Console.WriteLine("The greater number is: " + numberA);
        }
        else if ((numberB >= numberA) && (numberB >= numberC))
        {
            Console.WriteLine("The greater number is: " + numberB);
        }
        else if ((numberC >= numberA) && (numberC >= numberB))
        {
            Console.WriteLine("The greater number is: " + numberC);
        }
    }
}
