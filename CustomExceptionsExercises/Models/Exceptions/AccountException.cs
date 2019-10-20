using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionsExercises.Models.Exceptions
{
    public class AccountException : ApplicationException
    {
        public AccountException(string msg) : base(msg)
        {
        }
    }
}
