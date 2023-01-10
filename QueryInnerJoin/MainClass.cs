using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryInnerJoin
{
    class MainClass
    {
        static void Main()
        {
            List<Department> Departments = new List<Department>()
        {
            new Department(){DID=101,Name="Sales"},
            new Department(){DID=102,Name="Marketing"},
            new Department(){DID=103,Name="Software"}

        };
            List<Employee> Employees = new List<Employee>()
        {
            new Employee(){EmpID=1001,Name="ab",DeptID=101},
            new Employee(){EmpID=1002,Name="bc",DeptID=102},
            new Employee(){EmpID=1003,Name="cd",DeptID=103},
            new Employee(){EmpID=1004,Name="de",DeptID=102},
            new Employee(){EmpID=1005,Name="ef",DeptID=103},
            new Employee(){EmpID=1006,Name="fg",DeptID=103}
        };
            //InnerJoin
            var innerjoin = from emp in Employees
                            join dept in Departments
                            on emp.DeptID equals dept.DID
                            select new { EmployeeName = emp.Name, DeptName = dept.Name };
            foreach(var item in innerjoin)
            {
               // Console.WriteLine(item);
                Console.WriteLine("EmployeeName: {0} in Department: {1}",item.EmployeeName,item.DeptName);
            }

        }
    }
}