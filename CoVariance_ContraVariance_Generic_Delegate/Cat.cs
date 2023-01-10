using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoVariance_ContraVariance_Generic_Delegate
{
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat Sound");
        }
    }
}
