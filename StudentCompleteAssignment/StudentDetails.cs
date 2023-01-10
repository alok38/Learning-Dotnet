using System;
using Exception_Library;
namespace PartialStudentClassAssignment
{
    public partial class Student
    {
        public Student()
        {

        }
        public Student(string name, int marks)
        {
            if (marks < 0)
            {
                throw new MarksNegativeException("Please enter positive marks");
            }
            else if (marks > 100)
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
        public override string ToString()
        {
            return "Rollno: " + this.rollNumber + " name: " + this._name + " marks: " + this._marks;
        }

    }
}
