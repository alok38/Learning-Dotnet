using CustomerMVCAssignment.DataAccesLayer;
using CustomerMVCAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerMVCAssignment.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        CustomerAdminEntities1 CustAdmin = new CustomerAdminEntities1();
        public ActionResult Register()
        {
            return View(new UserDetails());
        }
        public ActionResult SaveUser(UserDetails u)
        {
            AuthTable a = new AuthTable();
            a.UserName = u.UserName;
            a.Password = u.Password;
            CustAdmin.AuthTables.Add(a);
            CustAdmin.SaveChanges();
            return RedirectToAction("Login", "Authentication");
        }
    }
}