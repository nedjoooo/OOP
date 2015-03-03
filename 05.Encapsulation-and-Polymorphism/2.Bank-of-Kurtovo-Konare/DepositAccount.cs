using System;

namespace _2.Bank_of_Kurtovo_Konare
{
    public class DepositAccount : Account
    {
        public DepositAccount(string customerName, decimal balance, decimal interestRate, Customer customer)
            : base (customerName, balance, interestRate, customer)
        {

        }

        public void Withdraw(decimal withdraw)
        {
            if(withdraw > base.Balance)
            {
                throw new ArgumentException("Withdraw balance must be less deposit balance!");
            }
            base.Balance -= withdraw;
        }
        public override decimal CalculateInterest(int months)
        {
            if(this.Balance>1000)
            {
                return base.CalculateInterest(months);
            }
            return 0;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
