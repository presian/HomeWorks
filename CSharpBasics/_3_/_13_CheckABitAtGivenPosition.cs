using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Which bit you want: ");
        int position = int.Parse(Console.ReadLine());
        int tempNum = number >> position;
        int num = tempNum & 1;
        bool bit = (num == 1);
        Console.WriteLine("Has value of 1 the bit at position #{0} - {1}!", position, bit);
    }
}
