using System;

class NumbersNotDivisibleByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Please enter number (n): ");
        uint num = uint.Parse(Console.ReadLine());
        uint counter=1;
        while (counter <= num)
        {
            if ((counter % 3 != 0) && (counter % 7 != 0))
            {
                Console.Write(counter + " ");
            }
            counter++;
        }
    }
}

