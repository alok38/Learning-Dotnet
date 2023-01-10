using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    public class Employee
    {
        public int Id;
        public Employee(int id)
        {
            this.Id = id;
            Console.WriteLine("Constructor for Id: {0}",this.Id);
        }
        ~Employee(){
            Console.WriteLine("Destructor for Id: {0}",this.Id);
        }
    }
}
