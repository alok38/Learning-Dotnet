using CustomerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerAPI.Controllers
{
    public class CustomerController : ApiController
    {
        static readonly ICustomerRepository repository = new CustomerRepository();
        // GET api/values
        public IEnumerable<Customer> GetAllCustomers()
        {
            return repository.GetAll();
        }

        // GET api/values/5
        public Customer GetCustomerById(int id)
        {
            Customer item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        // POST api/values
        public Customer PostCustomer(Customer item)
        {
            item = repository.Add(item);
            return item;
        }

        // PUT api/values/5
        public void PutCustomer(int id,Customer customer)
        {
            customer.Id = id;
            if (!repository.Update(customer))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE api/values/5
        public void DeleteCustomer(int id)
        {
            Customer item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repository.Remove(id);
        }
    }
}
