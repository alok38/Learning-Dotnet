using System;

namespace IComparableExplanation
{
    public class Employee : IComparable
    {
        private int _salary;
        public Employee(int salary)
        {
            _salary = salary;
        }
        public int CompareTo(object obj)
        {
            return this._salary.CompareTo(((Employee)obj)._salary);
        }
        public override string ToString()
        {
            return "Salary: " + this._salary;
        }
    }
}
