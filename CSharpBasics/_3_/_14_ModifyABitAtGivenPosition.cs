using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter bit position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Please enter bit value: ");
        int value = int.Parse(Console.ReadLine());
        if (value == 0)
        {
            int tempNum = number & (~(1 << position));
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine(tempNum);
            Console.WriteLine(Convert.ToString(tempNum, 2).PadLeft(16, '0'));
        }
        else
        {
            int tempNumber = number | (1 << position);
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine(tempNumber);
            Console.WriteLine(Convert.ToString(tempNumber, 2).PadLeft(16, '0'));
        }      
    }
}
