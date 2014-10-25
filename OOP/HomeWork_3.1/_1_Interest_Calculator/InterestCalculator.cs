using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Interest_Calculator
{
    
    class InterestCalculator
    {
        private double money;
        private double interest;
        private double years;
        private decimal result;


        public double Money { get; set; }
        public double Interest { get; set; }
        public double Years { get; set; }

        public decimal Result
        {
            get { return result; }
            set { result = value; }
        }

        public delegate decimal CalculateInterest(double sumOfMoney, double interest, double years);
        public InterestCalculator(double money, double interest, double years, CalculateInterest del)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.Result = del(money, interest, years);
        }

        public override string ToString()
        {
            return String.Format("Money: {0}\nInterest: {1}%\nYears: {2}\nResult: {3:F4}",this.Money, this.Interest, this.Years, this.Result);
        }
    }
}
