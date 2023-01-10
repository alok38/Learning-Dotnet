using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Assignment
{
    public abstract class Student
    {
        public static int totalStudents = 0;
        private string _name;
        private string _class;



        public Student(string name, string sclass)
        {
            totalStudents++;
            this._name = name;
            this._class = sclass;
        }

        public abstract int getPercentage();
        public static int getTotalNoStudents()
        {
            return totalStudents;
        }

    }


}
