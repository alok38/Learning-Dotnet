using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Student_Project
{
    class Course
    {
        public int courseID;
        public decimal fees;
        public string courseName;
        public int durationInMonths;
        [Key]
        public int Cid
        {
            get
            {
                return courseID;
            }
            set
            {
                courseID = value;
            }
        }
        public decimal Fees
        {
            get
            {
                return fees;
            }
            set { fees = value; }
        }
        public string CourseName {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }
        public int Duration
        {
            get { return durationInMonths; }
            set
            {
               durationInMonths = value;
            }
        }
    }
}
