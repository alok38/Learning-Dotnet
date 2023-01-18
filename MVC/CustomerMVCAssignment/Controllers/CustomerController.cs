using CustomerMVCAssignment.Models;
using CustomerMVCAssignment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerMVCAssignment.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult GetCustomers()
        {
            CustomerRecordsViewModel custRecords = new CustomerRecordsViewModel();
            List<CustomerViewModel> custViewModels = new List<CustomerViewModel>();
            CustomerBusinessLayer custBusiness = new CustomerBusinessLayer();
            List<Customer> customers = custBusiness.GetCustomers();



            foreach (Customer cust in customers)
            {
                CustomerViewModel cvm = new CustomerViewModel();
                cvm.CustomerID = cust.CustomerID;
                cvm.CustomerName = cust.FirstName + " " + cust.LastName;
                cvm.Age = (int)cust.Age;
                if (cust.Age > 18)
                {
                    cvm.AgeColor = "Green";
                }
                else
                {
                    cvm.AgeColor = "Red";
                }
                custViewModels.Add(cvm);




            }
            custRecords.MyCustomers = custViewModels;
            return View(custRecords);
        }
        public ActionResult AddNew()
        {
            return View("createCustomer", new CreateCustomerViewModel());
        }
       
        public ActionResult SaveCustomer(Customer c,string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Customer":
                    if (ModelState.IsValid)
                    {
                        CustomerBusinessLayer custBal = new CustomerBusinessLayer();
                        custBal.SaveCustomer(c);
                        return RedirectToAction("GetCustomers");
                    }
                    else
                    {
                        //return View("CreateEmployee");
                        //to retain value back in case of validation faliure
                        CreateCustomerViewModel cm = new CreateCustomerViewModel();
                        cm.FirstName = c.FirstName;
                        cm.LastName = c.LastName;
                        return View("CreateCustomer", cm);
                    }
                case "Cancel":
                    return RedirectToAction("GetCustomers");




            }
            return new EmptyResult();
        }
    }
}