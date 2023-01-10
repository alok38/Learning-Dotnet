using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExplanation
{
   public class Student : IComparable
    {
        private int _marks;
        public Student(int marks)
        {
           this._marks = marks;
        }
        

        
        public int CompareTo(object o)
        {
           return this._marks.CompareTo(((Student)o)._marks);
        }
        public override string ToString()
        {
            return "marks: " + this._marks; 
        }
    }
}
