using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dynamic
{
    class Customer
    {
        public string customerName;
        public string Name
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public Customer()
        {
        }
        public Customer(int cId, string cName)
        {
            this.customerId = cId;
            this.customerName = cName;
        }
        public string SayHello(string name)
        {
            return "Hello :" + name;
        }
    }
}
