using Overriding_Virtual_Sealed_Words.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Overriding_Virtual_Sealed_Words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Paul", 1500);
            Account acc2 = new SavingsAccount(1002, "Silas", 1500, 0.01);

            acc1.WithDraw(10);
            acc2.WithDraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            Console.ReadKey();
        }
    }
}
