using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FractionCalculator
{
    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set 
            { 
                checked
                {
                    this.numerator = value; 
                }              
            }
        }
        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if(value == 0)
                {
                    throw new DivideByZeroException("Denominator can not be zero!");
                }
                checked
                {
                    this.denominator = value;
                }               
            }
        }

        public static Fraction operator +(Fraction fractionFirstValue, Fraction fractionSecondValue)
        {
            checked
            {
                long numerator = fractionFirstValue.Numerator * fractionSecondValue.Denominator +
                fractionFirstValue.Denominator * fractionSecondValue.Numerator;
                long denominator = fractionFirstValue.Denominator * fractionSecondValue.Denominator;
                return new Fraction(numerator, denominator);
            }           
        }

        public static Fraction operator -(Fraction fractionFirstValue, Fraction fractionSecondValue)
        {
            checked
            {
                long numerator = fractionFirstValue.Numerator * fractionSecondValue.Denominator -
                fractionFirstValue.Denominator * fractionSecondValue.Numerator;
                long denominator = fractionFirstValue.Denominator * fractionSecondValue.Denominator;
                return new Fraction(numerator, denominator);
            }           
        }
        public override string ToString()
        {
            decimal result = (decimal)this.Numerator / this.Denominator;
            return result.ToString();
        }
    }
}
