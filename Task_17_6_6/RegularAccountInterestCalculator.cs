﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_6_6
{
    public class RegularAccountInterestCalculator : IAccountInterestCalculator
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;
            else
                account.Interest -= account.Balance * 0.4;
        }
    }
}
