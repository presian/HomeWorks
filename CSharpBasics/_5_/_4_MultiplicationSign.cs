using System;

class MultiplicationSign
{
    static void Main()
    {   
        Console.Write("Please enter first number (a): ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter second number (b): ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please enter third number (c): ");
        double numberC = double.Parse(Console.ReadLine());
        if (numberA > 0 && numberB > 0 && numberC > 0)
        {
            Console.WriteLine('+');
        }
        if (numberA < 0 && numberB < 0 && numberC < 0)
        {
            Console.WriteLine('-');
        }
        if ((numberA < 0 && numberB < 0 && numberC > 0) || ((numberA < 0 && numberB > 0 && numberC < 0)) || (numberA > 0 && numberB < 0 && numberC < 0))
        {
            Console.WriteLine('+');
        }
        if ((numberA < 0 && numberB > 0 && numberC > 0) || ((numberA > 0 && numberB > 0 && numberC < 0)) || (numberA > 0 && numberB < 0 && numberC > 0))
        {
            Console.WriteLine('-');
        }
        if ((numberA == 0) || (numberB == 0) || (numberC == 0))
        {
            Console.WriteLine(0);
        }


        //double result = numberA * numberB * numberC;
        //if (result < 0)
        //{
        //    Console.WriteLine("-");  
        //}
        //else if (result > 0)
        //{
        //    Console.WriteLine("+");
        //}
        //else if (result == 0)
        //{
        //    Console.WriteLine("0");
        //}
    }
}
