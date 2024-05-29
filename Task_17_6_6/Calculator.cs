using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_6_6
{
    public static class Calculator
    {
        public static void CalculateInterest(Account account, IAccountInterestCalculator interestCalculator)
        {
            interestCalculator.CalculateInterest(account);
        }
    }
}
