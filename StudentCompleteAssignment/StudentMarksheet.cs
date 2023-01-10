using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialStudentClassAssignment
{
    public partial class Student
    {
        public string PrintMarksheet()
        {
            return string.Format("Marksheet:\nRollNumber: {0}\nName: {1}\nMarks: {2} ", this.rollNumber, this._name, this._marks);
        }
    }
}
