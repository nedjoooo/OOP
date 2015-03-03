using System;

namespace _2.Bank_of_Kurtovo_Konare
{
    interface IDepositAccount : IAccount
    {
        void Withdraw(decimal withdraw);
    }
}
