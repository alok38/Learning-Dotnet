using System;
using Exception_Library;

namespace Student_Exception_Assignment
{

    class Student
    {
        private static int id = 101;
        public readonly int rollNumber;
        private string _name;
        private int _marks;
        public Student(string name,int marks)
        {
            if(marks < 0)
            {
                throw new MarksNegativeException("Please enter positive marks");
            }
            else if(marks > 100)
            {
                throw new MarksOverException("please enter Marks less than 100");
            }
            else
            {
                this.rollNumber = id++;
                this._marks = marks;
                this._name = name;
            }
            
        }
        
        
          

    
        public string PrintMarksheet()
        {
            return string.Format("Marksheet:\nRollNumber: {0}\nName: {1}\nMarks: {2} ", this.rollNumber, this._name,  this._marks);
        }


    }
}

