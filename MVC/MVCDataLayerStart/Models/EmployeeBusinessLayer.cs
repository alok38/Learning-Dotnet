using MVCDataLayerStart.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDataLayerStart.Models
{
    public class EmployeeBusinessLayer
    {
        EmployeeContext salesDal;
        UserDBEntities userDb = new UserDBEntities();
        public EmployeeBusinessLayer()
        {
            salesDal = new EmployeeContext();
        }
        public List<Employee> GetEmployees()
        {
            return salesDal.Employees.ToList();
        }
        public Employee SaveEmployee(Employee e)
        {
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;




        }
        public bool IsValidUser(UserDetails u)
        {
            
            TblUser user = new TblUser();

            

            user.Name = u.UserName;
            user.Password = u.Password;



            var users = userDb.TblUsers.FirstOrDefault(x => x.Name == user.Name && x.Password == user.Password);



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