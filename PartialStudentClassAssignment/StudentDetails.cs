using System;
using Exception_Library;
namespace PartialStudentClassAssignment
{
    partial class Student
    {
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

    }
}
