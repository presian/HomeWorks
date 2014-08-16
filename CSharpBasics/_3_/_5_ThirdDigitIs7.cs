using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int num = int.Parse(Console.ReadLine());
        int number = num / 100;
        int tempnum = number % 10;
        bool digit = (tempnum == 7);
        Console.WriteLine("Is third digit 7?\t{0}", digit);
            
    }
}
