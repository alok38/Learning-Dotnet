using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    public class Employee : IDisposable
    {
        private bool isdisposed;
        private int id;
        private int salary;
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Employee(int id)
        {
            this.id = id;
            this.isdisposed = false;
            Console.WriteLine("Object instantiated for id={0}",this.id);
        }
        ~Employee()
        {
            if (!isdisposed)
            {
                this.Dispose();
            }
            Console.WriteLine("Object destroyed for id={0}",this.id);
        }
        public void workstatus()
        {
            if (this.isdisposed)
            {
                throw new ObjectDisposedException(this.id.ToString(), "Employee has been terminated");
            }
            else
            {
                Console.WriteLine("id="+this.id+" is working properly");
            }
        }
        public void IncrementSalary(int increment)
        {
            if (this.isdisposed)
            {
                throw new ObjectDisposedException(this.id.ToString(), "Employee has been terminated");
            }
            else
            {
                Console.WriteLine("Salary Incremented for Employee id={0}",this.id);
                this.salary += increment;
            }
        }
        public void Dispose()
        {
            Console.WriteLine(this.id+" is being Disposed");
            GC.SuppressFinalize(this);
            this.isdisposed = true;
        }
    }
}
