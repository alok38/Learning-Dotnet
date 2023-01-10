using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Student_Project
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            using(var co = new courseContext())
            {
                co.Courses.Add(new Course { fees = 40000, courseName = "Java", Duration = 6 });
                co.Courses.Add(new Course { fees = 20000, courseName = "C++", Duration = 4 });
                co.Courses.Add(new Course { fees = 25000, courseName = "C#", Duration = 5 });
                co.Courses.Add(new Course { fees = 10000, courseName = "C", Duration = 7 });
                co.Courses.Add(new Course { fees = 50000, courseName = "Python", Duration = 3 });

                co.SaveChanges();

                var all = from c in co.Courses.ToList()
                          select c;

                foreach(var c in all)
                {
                    Console.Write("Course ID: " + c.Cid + "\t");
                    Console.Write("Course Name: " + c.CourseName + "\t");
                    Console.Write("Course Fees: " + c.Fees + "\t");
                    Console.WriteLine("Course Duration: " + c.durationInMonths);
                    Console.WriteLine("-----------------------------------------------------------------------");
                }
            }
           
        }
    }
}
