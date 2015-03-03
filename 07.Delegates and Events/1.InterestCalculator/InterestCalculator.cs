using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class InterestCalculator
    {
        private decimal money;
        private decimal interest;
        private int years;
        private CalculateInterest calculateInterest;
        private decimal result;

        public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest calculateInterest)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.calculateInterest = new CalculateInterest(calculateInterest);
            this.Result = result;
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Money value can not be negative!");
                }
                this.money = value;
            }
        }
        public decimal Interest
        {
            get { return this.interest; }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Interest value can not be negative!");
                }
                this.interest = value;
            }
        }
        public int Years
        {
            get { return this.years; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Years value can not be negative!");
                }
                this.years = value;
            }
        }
        private decimal Result
        {
            get { return this.result; }
            set
            {
                this.result = this.calculateInterest(this.money, this.interest, this.years);
            }
        }
        public void PrintInterest()
        {
            Console.WriteLine(result.ToString("0.0000"));
        }
    }
}
