using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase_EntityFramework
{
    public class MainClass
    {
        static MyDatabaseEntities mdEntities = new MyDatabaseEntities();
        static void PrintAllEmployeeNames()
        {
            var Names = from emp in mdEntities.Employees
                        select emp.Name;
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
        static void InsertEmployee()
        {
            Console.WriteLine("Enter Employee Name: ");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            decimal empSalary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Emloyee DepartmentID: ");
            short empdid = Convert.ToInt16(Console.ReadLine());
            Employee emp = new Employee { Name = empName,
                                          Salary = empSalary,
                                          DID = empdid 
            
                                        };
            mdEntities.Employees.Add(emp);
            mdEntities.SaveChanges();
            Console.WriteLine("Employee Added");
        }
        static void UpdateEmployee()
        {
            Console.WriteLine("Enter Employee ID");
            short empid = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            decimal empSalary = Decimal.Parse(Console.ReadLine());
            IEnumerable<Employee> emp;
            emp = (from e in mdEntities.Employees
                   where e.ID == empid
                   select e);
            foreach(var p in emp)
            {
                p.Name = empName;
                p.Salary = empSalary;

            }
           
            mdEntities.SaveChanges();
            Console.WriteLine("Updated");
        }
        static void DeleteEmployee()
        {
            Console.WriteLine("Enter ID");
            int id = Convert.ToInt32(Console.ReadLine());
            IEnumerable<Employee> emp;
            Employee empl = (Employee)( from e in mdEntities.Employees
                            where id == e.ID
                            select e);

            mdEntities.Employees.Remove(empl);
            mdEntities.SaveChanges();
        }
        static void Main(string[] args)
        {
            //InsertEmployee();
           // UpdateEmployee();
           // PrintAllEmployeeNames();
           
        }
    }
}
