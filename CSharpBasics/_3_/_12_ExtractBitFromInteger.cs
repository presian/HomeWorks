using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Please enter integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Which bit you want: ");
        int place = int.Parse(Console.ReadLine());
        int tempnum = number >> place;
        int bit = tempnum & 1;
        Console.Write("Value of {0} bit is: {1} \n", place, bit);
    }
}
