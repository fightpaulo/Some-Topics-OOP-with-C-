using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions.Models.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string msg) : base(msg)
        {

        }
    }
}
