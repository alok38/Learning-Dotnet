using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string SayHello()
        {
            return "Hello i Am Learming MVC";
        }



        public string NoHello()
        {
            return String.Empty;
        }



        public ActionResult NoGreeting()
        {
            return new EmptyResult();
        }



        [NonAction]
        public String SimpleMethod()
        {
            return "I am not an Action Method !";
        }



        public Customer GetCustomer()
        {
            Customer customer = new Customer();
            customer.CustomerName = "Alok";
            customer.Address = "Pune";
            return customer;
        }



        public ActionResult GetMyView()
        {
            return View("MyView");
        }



        public ActionResult GetView()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAnotherEmployee()
        {
           Employee emp = new Employee();
            emp.FirstName = "Alok";
            emp.LastName = "Goswami";
            emp.Salary = 20000;
            //ViewBag.MyEmployee = emp;
            ViewData["MyEmployee"] = emp;
            return View();
        }
        public ActionResult GetEmployee()
        {
            //Controller Action Method is taking object from Model adding for properties 
            Employee emp = new Employee();
            emp.FirstName = "Alok";
            emp.LastName = "Goswami";
            emp.Salary = 20000;
            //ViewDataDictionary d = base.ViewData;
            //d["MyEmployee"] = emp;
            //ViewData["MyEmployee"] = emp;

            ViewBag.MyEmployee = emp;//pass it as viewbag and get it as viewData
            return View();
        }
        public ActionResult GetEmployeeView()
        {
            return View();
        }
        public ActionResult EmployeeTypedView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Alok";
            emp.LastName = "Goswami";
            emp.Salary = 20000;
            return View(emp);
        }
        public ActionResult GetEmployeeViewModelData()
        {
            Employee emp = new Employee();
            emp.FirstName = "Alok";
            emp.LastName = "Goswami";
            emp.Salary = 20000;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");
            if(emp.Salary > 15000)
            {
                vmEmp.SalaryColor = "yellow";
            }
            else
            {
                vmEmp.SalaryColor = "green";
            }
            vmEmp.UserName = "Admin";
            return View("EmployeeViewModel_View", vmEmp);
        }
        public ActionResult EmployeeListView()
        {
            AnotherEmployeeListViewModel employeeListViewModel = new AnotherEmployeeListViewModel();

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();

            List<AnotherEmployeeViewModel> empViewModels = new List<AnotherEmployeeViewModel>();

            foreach(Employee emp in employees)
            {
                AnotherEmployeeViewModel empViewModel = new AnotherEmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if(emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.MyEmployees = empViewModels;

            employeeListViewModel.UserName = "Admin";
            return View("EmployeeListView", employeeListViewModel);
        }
    }
}