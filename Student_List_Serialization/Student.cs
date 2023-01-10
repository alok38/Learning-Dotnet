using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_List_Serialization
{
    [Serializable]
    public class Student
    {
        public int studentId;
        public string name;
        public Student()
        {

        }
        public Student(int studentId, string name)
        {
            this.studentId = studentId;
            this.name = name;
        }
        public override string ToString()
        {
            return "Student Id: " + this.studentId + " \n Student Name: " + this.name;
        }

        
    }
}
