using System;

namespace Employee_Example
{
    internal class Employee
    {
        private static int id = 101;
        private int _empId;
        private string _empName;
        private decimal _basic;
        private decimal _da;
        private decimal _hra;
        private decimal _empSalary;
        public Employee(string name, decimal basic, decimal da, decimal hra)
        {
            this._empId = id++;
            this._empName = name;
            this._basic = basic;
            this._da = da;
            this._hra = hra;
            this._empSalary = basic + da + hra;
        }
        public int Id
        {
            get
            {
                return this._empId;
            }
        }
        public string printSalarySlip()
        {
            return string.Format("Employee Id: {0}\nName: {1}\nBasic: {2}\nDa: {3}\nHra: {4}\nTotal Salary: {5}\n----------------------", _empId, _empName, _basic, _da, _hra, _empSalary);
        }
    }
}
