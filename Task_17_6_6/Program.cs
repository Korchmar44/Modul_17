using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account { Type = "Обычный", Balance = 800 };
            Account account2 = new Account { Type = "Зарплатный", Balance = 2000 };

            IAccountInterestCalculator regularCalculator = new RegularAccountInterestCalculator();
            IAccountInterestCalculator salaryCalculator = new SalaryAccountInterestCalculator();

            Calculator.CalculateInterest(account1, regularCalculator);
            Calculator.CalculateInterest(account2, salaryCalculator);

            Console.WriteLine("Проценты по обычному счету: " + account1.Interest);
            Console.WriteLine("Проценты по Зарплатному счету: " + account2.Interest);

            Console.ReadKey();
        }
    }
}
