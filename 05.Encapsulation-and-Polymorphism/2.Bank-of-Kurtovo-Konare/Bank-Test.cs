using System;
using System.Collections.Generic;

namespace _2.Bank_of_Kurtovo_Konare
{
    class Bank
    {
        static void Main(string[] args)
        {
            DepositAccount depositIndividual = new DepositAccount("Bai Stoyan", 5000m, 5m, Customer.Individual);
            Console.WriteLine(depositIndividual.ToString());
            Console.WriteLine("Account: {0}, Interest sum is: {1:0.00}",
                depositIndividual.GetType().Name, depositIndividual.CalculateInterest(60));
            depositIndividual.Withdraw(500m);            
            Console.WriteLine("After withdraw: {0}", depositIndividual.Balance);
            depositIndividual.Deposit(1000m);
            Console.WriteLine("After deposit: {0}", depositIndividual.Balance);
            Console.WriteLine();


            DepositAccount depositCompany = new DepositAccount("Saveta na Kaspichan", 2400225m, 5.15m, Customer.Company);
            Console.WriteLine(depositCompany.ToString());
            Console.WriteLine("Account: {0}, Interest sum is: {1:0.00}",
                depositCompany.GetType().Name, depositCompany.CalculateInterest(60));
            depositCompany.Withdraw(500m);
            Console.WriteLine("After withdraw: {0}", depositCompany.Balance);
            depositCompany.Deposit(1000m);
            Console.WriteLine("After deposit: {0}", depositCompany.Balance);
            Console.WriteLine();


            LoanAccount loanIndividual = new LoanAccount("Biznesmena", 1300000m, 3.65m, Customer.Individual);
            Console.WriteLine(loanIndividual.ToString());
            Console.WriteLine("Account: {0}, Interest sum is: {1:0.00}",
                loanIndividual.GetType().Name, loanIndividual.CalculateInterest(60));
            loanIndividual.Deposit(1000m);
            Console.WriteLine("After deposit: {0}", loanIndividual.Balance);
            Console.WriteLine();


            LoanAccount loanCompany = new LoanAccount("Roca Company", 200000m, 3.5m, Customer.Company);
            Console.WriteLine(loanCompany.ToString());
            Console.WriteLine("Account: {0}, Interest sum is: {1:0.00}",
                loanCompany.GetType().Name, loanCompany.CalculateInterest(60));
            loanCompany.Deposit(1000m);
            Console.WriteLine("After deposit: {0}", loanCompany.Balance);
            Console.WriteLine();


            MortgageAccount mortgageIndividual = new MortgageAccount("Gesho Peshev", 66700m, 5.75m, Customer.Individual);
            Console.WriteLine(mortgageIndividual.ToString());
            Console.WriteLine("Account: {0}, Interest sum is: {1:0.00}",
                mortgageIndividual.GetType().Name, mortgageIndividual.CalculateInterest(60));
            mortgageIndividual.Deposit(1000m);
            Console.WriteLine("After deposit: {0}", mortgageIndividual.Balance);
            Console.WriteLine();


            MortgageAccount mortgageCompany = new MortgageAccount("Ivan & co Software", 153600m, 4.85m, Customer.Company);
            Console.WriteLine(mortgageCompany.ToString());
            Console.WriteLine("Account: {0}, Interest sum is: {1:0.00}",
                mortgageCompany.GetType().Name, mortgageCompany.CalculateInterest(60));
            mortgageCompany.Deposit(1000m);
            Console.WriteLine("After deposit: {0}", mortgageCompany.Balance);
            Console.WriteLine();
            
            List<Account> accounts = new List<Account>();
            accounts.Add(depositIndividual);
            accounts.Add(depositCompany);
            accounts.Add(loanIndividual);
            accounts.Add(loanCompany);
            accounts.Add(mortgageIndividual);
            accounts.Add(mortgageCompany);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Customers interest is:");
            foreach (var account in accounts)
            {
                DepositAccount depositAccount = new DepositAccount("test", 1000m, 5m, Customer.Individual);
                Console.WriteLine(account.ToString());
                Console.WriteLine("Account: {0}, Interest sum is: {1:0.00}",
                    account.GetType().Name, account.CalculateInterest(60));
                Console.WriteLine();
            }

            
        }
    }
}
