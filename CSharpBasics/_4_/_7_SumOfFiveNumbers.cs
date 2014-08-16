using System;
using System.Linq;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("please enter five numbers in row: ");
        var row = Console.ReadLine().Split().Take(5);
        double[] numbers = row.Select(d => Convert.ToDouble(d)).ToArray();
        double sum = numbers.Sum();
        Console.WriteLine("Sum is: {0}", sum);     
    }
}
