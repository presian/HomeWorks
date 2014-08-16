using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please enter first integer (a): ");
        int numberA = int.Parse(Console.ReadLine());
        Console.Write("Please enter first integer (b): ");
        int numberB = int.Parse(Console.ReadLine());
        int tempNum = 0;
        if (numberA > numberB)
	    {
            tempNum = numberB;
            numberB = numberA;
            numberA = tempNum;
		    Console.WriteLine(numberA + " " + numberB); 
	    }
        else
        {
            Console.WriteLine(numberA + " " + numberB);       
	    }
    }
}

