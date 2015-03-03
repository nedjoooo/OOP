using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateInterest simpleInterestMethod = InterestCalculationMethods.GetSimpleInterest;
            CalculateInterest compoundInterestMethod = InterestCalculationMethods.GetCompoundInterest;

            var simpleInterest = new InterestCalculator(500m, 5.6m, 10, compoundInterestMethod);
            var compoundInterest = new InterestCalculator(2500m, 7.2m, 15, simpleInterestMethod);

            simpleInterest.PrintInterest();
            compoundInterest.PrintInterest();
        }
    }
}
