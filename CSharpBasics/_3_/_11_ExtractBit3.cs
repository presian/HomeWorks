using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Please insert unsigned integer: ");
        uint number = uint.Parse(Console.ReadLine());
        uint tempnum = number >> 3;
        uint num = tempnum & 1;
        Console.Write("Value of the bit # 3 is: ");
        Console.WriteLine(num);
    }
}

