using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var cust = new MyDAL())
            {
                cust.Departments.Add(new Department { DeptId = 1 ,DeptName = "Hr"});
                cust.Projects.Add(new Project { ProjectId = 1, ProjectClient = "OMK", ProjectName="bomk" });
                cust.Employees.Add(new Employee { Name = "Sanjeev", Gender = "M",DepartmentId=1,ProjectId=1,Salary=12000 });
                

                cust.SaveChanges();

                var customerQuery = from c in cust.Employees.ToList()
                                    select c;

                foreach (var customer in customerQuery)
                {
                    Console.Write(customer.Name + "\t");
                    Console.WriteLine(customer.Salary);
                    Console.WriteLine(customer.Gender);
                    Console.WriteLine(customer.DepartmentId);
                    Console.WriteLine(customer.ProjectId);
                }

            }
        }
    }
}
