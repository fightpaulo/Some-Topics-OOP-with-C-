using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Virtual_Sealed_Words.Models
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // It indicates this method can be overrided in a subclass
        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
