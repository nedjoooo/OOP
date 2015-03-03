using System;

namespace _2.Bank_of_Kurtovo_Konare
{
    public abstract class Account : IAccount
    {
        private string customerName;
        private decimal balance;
        private decimal interestRate;
        private Customer customer;
        public Account(string customerName, decimal balance, decimal interestRate, Customer customer)
        {
            this.CustomerName = customerName;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }
        public string CustomerName
        {
            get { return this.customerName; }
            private set
            {
                if(string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentNullException("Customer identity name must be minimum three letters!");
                }
                this.customerName = value;
            }
        }
        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                try
                {
                    if(value.Equals(null))
                    {
                        throw new ArgumentNullException();
                    }
                    if(value < 0)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    this.balance = value;
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("Balance can not be empty!");
                }
                catch
                {
                    Console.WriteLine("Balance can not be negative!");
                }
            }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            protected set
            {
                try
                {
                    if (value.Equals(null))
                    {
                        throw new ArgumentNullException();
                    }
                    if (value < 0)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    this.interestRate = value;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Balance can not be empty!");
                }
                catch
                {
                    Console.WriteLine("Balance can not be negative!");
                }
            }
        }
        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public void Deposit(decimal deposit)
        {
            if (deposit <= 0 || deposit.Equals(null))
            {
                throw new ArgumentException("Deposit balance can not empty or negative!");
            }
            this.Balance += deposit;
        }
        public virtual decimal CalculateInterest(int months)
        {
            if (months < 1)
            {
                throw new ArgumentOutOfRangeException("Months can not be zero or negative!");
            }
            return this.Balance * (1 + ((this.InterestRate / 100) * months) / 12) - this.Balance;
        }
        public override string ToString()
        {
            return String.Format("Customer: {0}, Balance: {1}, Interest Rate: {2}, Customer: {3}",
                this.CustomerName, this.Balance, this.InterestRate, this.Customer);
        }
    }
}
