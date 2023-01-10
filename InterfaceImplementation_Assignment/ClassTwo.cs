using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation_Assignment
{
    public class ClassTwo : ClassOne, InterfaceFour
    {
        public override void MethodThree()
        {
            Console.WriteLine("Method Three : Class Two");
        }

        public void MethodFour()
        {
            Console.WriteLine("Method Four : Class Two");
        }
    }
}
