using System;

namespace Student_Polymorphism_Example
{
    class Student
    {
        protected static int id = 101;
        protected int rollNumber;
        protected string studentName;
        protected decimal englishMarks;
        protected decimal generalStudiesMarks;
        protected decimal environmentStudiesMarks;
        public Student(string name, decimal englishMarks, decimal genStudiesMarks, decimal envStudiesMarks)
        {
            this.rollNumber = id++;
            this.studentName = name;
            this.englishMarks = englishMarks;
            this.generalStudiesMarks = genStudiesMarks;
            this.environmentStudiesMarks = envStudiesMarks;

        }
        public int RollNumber
        {
            get
            {
                return this.rollNumber;
            }
        }
        public virtual string printMarksheet()
        {
            return string.Format("Student Marksheet:\nStudent RollNumber: {0}\nStudent Name: {1}\nEnglish Marks: {2}\ngeneralStudiesMarks: {3}\nenvironmentStudiesMarks: {4}", this.rollNumber, this.studentName, this.englishMarks, this.generalStudiesMarks, this.environmentStudiesMarks);
        }
    }
    class ScienceStudent : Student
    {
        protected decimal scienceMarks;
        public ScienceStudent(string name, decimal englishMarks, decimal genStudiesMarks, decimal envStudiesMarks, decimal scienceMarks) : base(name, englishMarks, genStudiesMarks, envStudiesMarks)
        {
            this.scienceMarks = scienceMarks;
        }
        public override string printMarksheet()
        {
            return base.printMarksheet() + "\nscienceMarks: " + this.scienceMarks + "\nStream: Science";
        }
    }
    class CommerceStudent : Student
    {
        protected decimal commerceMarks;
        public CommerceStudent(string name, decimal englishMarks, decimal genStudiesMarks, decimal envStudiesMarks, decimal commerceMarks) : base(name, englishMarks, genStudiesMarks, envStudiesMarks)
        {
            this.commerceMarks = commerceMarks;
        }
        public override string printMarksheet()
        {
            return base.printMarksheet() + "\nCommerce Marks: " + this.commerceMarks + "\nStream: Commerce";
        }
    }
    class ArtsStudent : Student
    {
        protected decimal socialStudiesMarks;
        public ArtsStudent(string name, decimal englishMarks, decimal genStudiesMarks, decimal envStudiesMarks, decimal socialStudiesMarks) : base(name, englishMarks, genStudiesMarks, envStudiesMarks)
        {
            this.socialStudiesMarks = socialStudiesMarks;
        }
        public override string printMarksheet()
        {
            return base.printMarksheet() + "\nsocialStudiesMarks: " + this.socialStudiesMarks + "\nStream: Arts";
        }
    }
}
