using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Virtual_Sealed_Words.Models
{
    // A sealed class cannot be inherited
    public sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // It indicates this method overrided its superclass
        public sealed override void WithDraw(double amount)
        {
            Balance -= amount;
        }
    }
}
