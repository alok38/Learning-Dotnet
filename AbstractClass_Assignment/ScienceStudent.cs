using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Assignment
{
    public class ScienceStudent : Student
    {
        public static int noOfStudents = 0;
        private int _phisicsMarks;
        private int _chemistryMarks;
        private int _mathsMarks;

        public int PhysicsMarks
        {
            get { return this._phisicsMarks; }
            set { this._phisicsMarks = value; }
        }

        public int ChemistryMarks
        {
            set { this._chemistryMarks = value; }
        }

        public int MathsMarks
        {
            set { this._mathsMarks = value; }
        }

        public ScienceStudent(string name, string sclass) : base(name, sclass)
        {
            noOfStudents++;
        }

        public override int getPercentage()
        {
            int percent = ((this._phisicsMarks + this._chemistryMarks + this._mathsMarks) * 100) / 300;

            return percent;
        }
    }
}
