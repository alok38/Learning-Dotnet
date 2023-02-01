using CustomerAPI.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerAPI.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        MyDAL Cust;

        public List<Customer> customers = new List<Customer>();
        private int _nextId = 1;
        public CustomerRepository()
        {
            Cust = new MyDAL();
        }
        public IEnumerable<Customer> GetAll()
        {
            return Cust.Customers;
        }
        public Customer Get(int id)
        {
            return Cust.Customers.Find(id);
        }
        public Customer Add(Customer item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            Cust.Customers.Add(item);
            Cust.SaveChanges();
            return item;
        }
        public void Remove(int id)
        {
            Cust.Customers.Remove(Cust.Customers.Find(id));
            Cust.SaveChanges();
        }
        public bool Update(Customer item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            Customer found = Cust.Customers.Find(item);

            found.Name = item.Name;
            found.Address = item.Address;
            found.Age = item.Age;
            Cust.SaveChanges();
            return true;
        }
    }
}