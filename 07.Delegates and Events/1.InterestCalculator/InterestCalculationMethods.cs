using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public delegate decimal CalculateInterest(decimal sumOfMoney, decimal interest, int years);
    public class InterestCalculationMethods
    {
        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            decimal result = sum * (decimal)(1 + interest / 100 * years);
            return result;
        }
        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            decimal result = sum * Convert.ToDecimal(Math.Pow(1 + ((double)interest / 12 / 100), years * 12));
            return result;
        }
    }
}
