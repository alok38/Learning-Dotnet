using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
   public class Person
    {
        //AutoImplemetedProperties
        public int Age { get; set; }
        public string Name { get; set; }
        public string City;
        public Person()
        {
            Console.WriteLine("Default");
        }
    }
}
