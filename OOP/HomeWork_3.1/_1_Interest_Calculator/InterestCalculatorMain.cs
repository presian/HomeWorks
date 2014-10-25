using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Interest_Calculator
{
    class InterestCalculatorMain
    {
        static void Main(string[] args)
        {
            InterestCalculator firstCalculator = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            InterestCalculator secondCalculator = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine(firstCalculator);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(secondCalculator);
        }

        static decimal GetSimpleInterest(double sum, double interest, double years)
        {
            decimal result = (decimal)(sum * (1 + interest/100 * years));
            return result;
        }

        static decimal GetCompoundInterest(double sum, double interest, double years)
        {
            const int N = 12;
            decimal result = (decimal)(sum * Math.Pow((1+interest/100/N),(years*N)));
            return result;
        }
    }
}
