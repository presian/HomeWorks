using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please enter number # 1: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter number # 2: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please enter number # 3: ");
        double numberC = double.Parse(Console.ReadLine());
        Console.Write("Please enter number # 4: ");
        double numberD = double.Parse(Console.ReadLine());
        Console.Write("Please enter number # 5: ");
        double numberE = double.Parse(Console.ReadLine());
        if ((numberA >= numberB) && (numberA >= numberC) && (numberA >= numberD) && (numberA >= numberE))
        {
            Console.WriteLine("The greater number is " + numberA);
        }
        else if ((numberA <= numberB) && (numberB >= numberC) && (numberB >= numberD) && (numberB >= numberE))
        {
            Console.WriteLine("The greater number is " + numberB);
        }
        else if ((numberA <= numberC) && (numberB <= numberC) && (numberC >= numberD) && (numberC >= numberE))
        {
            Console.WriteLine("The greater number is " + numberC);
        }
        else if ((numberA <= numberD) && (numberD >= numberB) && (numberD >= numberC) && (numberD >= numberE))
        {
            Console.WriteLine("The greater number is " + numberD);
        }
        else if ((numberA <= numberE) && (numberE >= numberB) && (numberE >= numberC) && (numberE >= numberD))
        {
            Console.WriteLine("The greater number is " + numberE);
        }
    }
}

