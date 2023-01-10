

using System;

using System.Collections.Generic;
//Implicitly Typed Local Variable
namespace ImplicitlyTypedLocalVariable
{
    struct Student
    {
        public int RollNumber;
    }
    public class MainClass
    {
        static void Main()
        {
            int k = 10;
            var intValue = k++;
            Console.WriteLine("intValue={0}", ++intValue);
            //Declarator must include initializer 
            //var i;
            //i=10; throws an error
            //the compile time type of initializer cannot be null
            //var p = null; not allowed
            var stringValue = "Alok";
            Console.WriteLine("String value: " + stringValue);
            //var intArray = {"1","2","3"}; error collection initializer not permitted

            var intArray = new int[] { 1, 2, 3 };
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------------");
            var empobj = new Employee();
            empobj.EmpId = 101;
            Console.WriteLine(empobj.EmpId);
            Employee emp = new Employee();
            empobj = emp;
            empobj.EmpId = 102;
            Console.WriteLine(empobj.EmpId);
            Console.WriteLine(emp.EmpId);

            Student s = new Student();
            var studentObj = s;
            studentObj.RollNumber = 10;
            Console.WriteLine("roll num = " + studentObj.RollNumber);
        }
    }





}

