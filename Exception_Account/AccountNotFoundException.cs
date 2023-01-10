using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Account
{
    public class AccountNotFoundException : Exception
    {
        public AccountNotFoundException(string message) : base(message)
        {

        }

    }
}
