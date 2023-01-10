using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation_Assignment
{
    public abstract class ClassOne : InterfaceThree
    {
        public void MethodOne()
        {
            Console.WriteLine("Method One : Class One");
        }

        public void MethodTwo()
        {
            Console.WriteLine("Method Two : Class One");
        }

        public abstract void MethodThree();

    }
}
