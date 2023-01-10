using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Assignment
{
    public class HistoryStudent : Student
    {
        public static int noOfStudents = 0;
        private int _historyMarks;
        private int _civicsMarks;

        public int HistoryMarks
        {
            set { this._historyMarks = value; }
        }



        public int CivicsMarks
        {
            set { this._civicsMarks = value; }
        }

        public HistoryStudent(string name, string sclass) : base(name, sclass)
        {
            noOfStudents++;
        }

        public override int getPercentage()
        {
            return ((this._historyMarks + this._civicsMarks) * 100) / 200;
        }
    }




}
