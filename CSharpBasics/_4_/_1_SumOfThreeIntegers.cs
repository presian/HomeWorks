using System;

class SumOfThreeIntegers
{
    static void Main()
    {
        Console.Write("Please enter first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter third integer: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine(sum);
    }
}