using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Fraction_Calculator
{
    class FractionCalculator
    {
        static void Main(string[] args)
        {
            int[] nums = new int[2];
            int[] denum = new int[2];
            for (int i = 1; i <= 2; i++)
            {
                Console.Write("Please enter numerator #" + i);
                nums[i-1] = int.Parse(Console.ReadLine());
                Console.Write("Please enter denominator #" + i);
                denum[i - 1] = int.Parse(Console.ReadLine());
            }

            Fraction first = new Fraction(nums[0],denum[0]);
            Fraction second = new Fraction(nums[1],denum[1]);
            Fraction result = first + second;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
            
        }
    }
}
