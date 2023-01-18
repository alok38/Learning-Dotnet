using CustomerMVCAssignment.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMVCAssignment.Models
{
    public class CustomerBusinessLayer
    {
        CustomerContext CustDal;
        CustomerAdminEntities1 CustAdmin = new CustomerAdminEntities1();
        public CustomerBusinessLayer()
        {
            CustDal = new CustomerContext();
        }
        public List<Customer> GetCustomers()
        {
            return CustDal.Customers.ToList();
        }
        public Customer SaveCustomer(Customer c)
        {
            CustDal.Customers.Add(c);
            CustDal.SaveChanges();
            return c;
        }
        public bool IsValidUser(UserDetails u)
        {

            AuthTable Auth = new AuthTable();



            Auth.UserName = u.UserName;
            Auth.Password = u.Password;



            var users = CustAdmin.AuthTables.FirstOrDefault(x => x.UserName == Auth.UserName && x.Password == Auth.Password);



            if (users == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            //if (u.UserName == "Dhiraj" && u.Password == "Dhiraj")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }

}

