using System;

namespace _2.Bank_of_Kurtovo_Konare
{
    class LoanAccount : Account
    {
        public LoanAccount(string customerName, decimal balance, decimal interestRate, Customer customer)
            : base(customerName, balance, interestRate, customer)
        {

        }
        public override decimal CalculateInterest(int months)
        {
            if (months < 1)
            {
                throw new ArgumentOutOfRangeException("Months can not be zero or negative!");
            }
            decimal interest = 0m;
            if (this.Customer == Customer.Individual)
            {
                if(months <= 3)
                {
                    return 0;
                }
                else
                {
                    interest = base.CalculateInterest(months - 3);
                }                
            }
            if (this.Customer == Customer.Company)
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    interest = base.CalculateInterest(months - 2);
                }
            }
            return interest;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
