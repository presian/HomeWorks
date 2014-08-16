using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Write a number:");
        int num = int.Parse(Console.ReadLine());
        int number = (num % 2);
        if (number < 1)
        {
            Console.WriteLine("\nThe number is Even");
        }
        else
        {
            Console.WriteLine("\nThe number is Odd");      
        }
            

    }
}
