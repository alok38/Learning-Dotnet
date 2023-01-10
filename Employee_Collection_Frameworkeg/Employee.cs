using System;

namespace Employee_Collection_Frameworkeg
{
     class Employee
    {
       private static int _id = 101;
        public readonly int EmpId;
        private string _name;
        public Employee(string name)
        {
            this.EmpId = _id++;
            this._name = name;
        }
        public override string ToString()
        {
            return "Employee Details:\n1.EmployeeId: "+ this.EmpId +"\n2.Employee Name: " + this._name;
        }
    }
}
