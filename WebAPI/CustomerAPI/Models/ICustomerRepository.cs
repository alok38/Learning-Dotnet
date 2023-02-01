using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAPI.Models
{
    internal interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
        Customer Add(Customer item);
        void Remove(int id);
        bool Update(Customer item);
    }
}
