using System;

class SortThreeNumbers
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
            if (numberB >= numberC)
            {
                Console.WriteLine(numberA + " " + numberB + " " + numberC); 
            }
            else
            {
                Console.WriteLine(numberA + " " + numberC + " " + numberB);
            }
        }
        else if ((numberB >= numberA) && (numberB >= numberC))
        {
            if (numberA >= numberC)
            {
                Console.WriteLine(numberB + " " + numberA + " " + numberC);
            }
            else
            {
                Console.WriteLine(numberB + " " + numberC + " " + numberA);
            }
        }
        else if ((numberC >= numberA) && (numberC >= numberB))
        {
            if (numberA >= numberB)
            {
                Console.WriteLine(numberC + " " + numberA + " " + numberB);
            }
            else
            {
                Console.WriteLine(numberC + " " + numberB + " " + numberA);
            }
        }
    }
}
