using InheritanceAndPolimorfism.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolimorfism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            // UPCASTING
            Account acc1 = bacc; // It works, because BusinessAccount is an Account
            Account acc2 = new BusinessAccount(1003, "Steven", 4000, 200);
            Account acc3 = new SavingsAccount(1004, "Ana", 0, 0.01);


            // DOWNCASTING (for this, it's important verify the object type
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc4 = acc3 as BusinessAccount;
                acc4.Loan(100);
            }
            else if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
            }

            Console.ReadKey();
        }
    }
}
