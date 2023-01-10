using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Library
{
    public class MarksOverException : Exception
    {
        public MarksOverException(string message) : base(message)
        {

        }
    }
}
