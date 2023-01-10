using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_Lamda 
{
    public class Employee : IComparable
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return "Employee Details: \nEmp Id: " + EmpId + " \nEmp Name " + EmpName + "\nEmp Salary " + Salary;
        }
        public int CompareTo(object obj)
        {
            Employee e = (Employee)obj;
            return this.Salary.CompareTo(e.Salary);
        }
    }
}
