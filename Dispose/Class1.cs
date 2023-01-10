using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispose 
{
    public class Class1 : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("run cleanup code here!");
        }
        ~Class1()
        {
            Console.WriteLine("Destructor for cleanup code");
        }
    }
}
