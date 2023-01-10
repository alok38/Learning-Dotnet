using System;
using System.Linq;


namespace EFCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var cust = new CustomerContext())
            {
                cust.Customers.Add(new Customer { Name = "Rajeev", City = "Mumbai" });
                cust.Customers.Add(new Customer { Name = "Sanjeev", City = "Chennai" });
                cust.Customers.Add(new Customer { Name = "Rajan", City = "Mumbai" });
                cust.Customers.Add(new Customer { Name = "Sajan", City = "Bangalore" });
                cust.Customers.Add(new Customer { Name = "Madhav", City = "Delhi" });
                cust.Customers.Add(new Customer { Name = "Sadhu", City = "Mumbai" });
                cust.Customers.Add(new Customer { Name = "Madhu", City = "Hyderabad" });
                cust.Customers.Add(new Customer { Name = "Raghav", City = "Mumbai" });
                cust.Customers.Add(new Customer { Name = "Sandu", City = "Bangalore" });

                cust.SaveChanges();

                var customerQuery = from c in cust.Customers.ToList()
                                    where c.City == "Mumbai"
                                    select c;

                foreach (var customer in customerQuery)
                {
                    Console.Write(customer.Name + "\t");
                    Console.WriteLine(customer.City);
                }

            }
            Console.WriteLine("---------------------------");
        }
    }
}
