using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Fraction_Calculator
{
    struct Fraction
    {
        private long numerator;
        private long denominator;

        public long Numerator { get { return this.numerator; } set { this.numerator = value; } }
        public long Denominator {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value==0)
                {
                    throw new ArgumentNullException(paramName: "denominator", message: "The denominator cannot be 0!");
                }
                this.denominator = value;
            }
        }

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            long numerator = first.numerator * second.denominator + second.numerator * first.denominator;
            long denominator = first.denominator * second.denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            long numerator = first.numerator * second.denominator - second.numerator * first.denominator;
            long denominator = first.denominator * second.denominator;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return String.Format("{0}",(decimal)numerator/denominator);
        }
    }
}
