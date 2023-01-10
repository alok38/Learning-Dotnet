using System;

namespace GarbageCollection
{
    class MianClass
    {
        static void Main()
        {
            using (Employee e1 = new Employee(101))
            {
                e1.Salary = 20000;
                e1.workstatus();
                e1.IncrementSalary(2000);
            }
            using (Employee e2 = new Employee(102))
            {
                e2.Salary = 18000;
                e2.workstatus();
                e2.IncrementSalary(4000);
            }
            //e1.Dispose();
            Console.WriteLine("--------------------------------");
            //e1.Salary = 100;
        }
    }
}