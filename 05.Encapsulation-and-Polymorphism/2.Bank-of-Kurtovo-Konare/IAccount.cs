﻿using System;

namespace _2.Bank_of_Kurtovo_Konare
{
    interface IAccount
    {
        void Deposit(decimal deposit);
        decimal CalculateInterest(int months);
    }
}