using CustomExceptionsExercises.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionsExercises.Models
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder)
        {
            Number = number;
            Holder = holder;

            Balance = 0;
            WithdrawLimit = 450;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new AccountException("O valor de depósito informado é inválido.");

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount <= 0)
                throw new AccountException("O valor de saque informado é inválido.");

            if (Balance < amount)
                throw new AccountException("Saldo insuficiente para realização do saque.");

            if(WithdrawLimit < amount)
                throw new AccountException($"Não foi possível realizar o saque, pois o valor informado excede seu limite de {WithdrawLimit}.");

            Balance -= amount;
        }
    }
}
