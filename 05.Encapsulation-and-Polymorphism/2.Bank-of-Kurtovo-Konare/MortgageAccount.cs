using System;

namespace _2.Bank_of_Kurtovo_Konare
{
    class MortgageAccount : Account
    {
        public MortgageAccount(string customerName, decimal balance, decimal interestRate, Customer customer)
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
                if (months <= 12)
                {
                    interest = (this.Balance * (1 + ((this.InterestRate / 100) * (months) / 12)) - this.Balance) / 2;
                }
                else
                {
                    interest = ((this.Balance * (1 + ((this.InterestRate / 100) * (months) / 12)) - this.Balance) / 2) +
                        base.CalculateInterest(months - 12);
                }
            }
            if (this.Customer == Customer.Company)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    interest = base.CalculateInterest(months - 6);
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
