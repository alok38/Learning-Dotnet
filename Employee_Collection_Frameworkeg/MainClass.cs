using System;
using System.Collections;

namespace Employee_Collection_Frameworkeg
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Employee("alok"));
            al.Add(new Employee("blok"));
            al.Add(new Employee("clok"));
            al.Add(new Employee("dlok"));
            al.Add(new Employee("elok"));
            IEnumerable en = al;
            foreach(Employee e in en)
            {
                Console.WriteLine(e);

            }
            Console.WriteLine("----------------------------------------");
            List<Employee> list = new List<Employee>();
            list.Add(new Employee("alok"));
            list.Add(new Employee("blok"));
            list.Add(new Employee("clok"));
            list.Add(new Employee("dlok"));
            list.Add(new Employee("elok"));
            IEnumerable en2 = list;
            foreach (Employee e in en2)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("----------------------------------------");
            
            SortedList<int, Employee> sl = new SortedList<int,Employee>();
            foreach(Employee e in list)
            {
                sl.Add(e.EmpId, e);
            }
          
            IEnumerable en3 = sl;
            IDictionaryEnumerator ie = (IDictionaryEnumerator)en3.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Value);
            }
            ie.Reset();
            Console.WriteLine("----------------------------------------");
            Hashtable hs = new Hashtable();
            foreach(Employee e in list)
            {
                hs.Add(e.EmpId, e);
            }
            
            IEnumerable en4 = hs;
            IDictionaryEnumerator ie2 = (IDictionaryEnumerator)en4.GetEnumerator();
            while (ie2.MoveNext())
            {
                Console.WriteLine(ie2.Value);
            }
            ie2.Reset();
           
            Console.WriteLine("-----------------------------------------");
        }
    }
}