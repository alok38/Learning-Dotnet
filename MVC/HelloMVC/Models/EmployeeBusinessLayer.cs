using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class EmployeeBusinessLayer
    {
       public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "Alok";
            emp.LastName = "Goswami";
            emp.Salary = 20000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "Blok";
            emp.LastName = "Hoswami";
            emp.Salary = 14000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "Clok";
            emp.LastName = "Ioswami";
            emp.Salary = 16000;
            employees.Add(emp);

            return employees;
        }
    }
}