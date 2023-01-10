using System;


namespace Student_Example
{
    class Student
    {
        private static int id = 101;
        private int _rollNumber;
        private string _studentName;
        private decimal _englishMarks;
        private decimal _scienceMarks;
        private decimal _socialStudiesMarks;
        private decimal _totalMarks;
        public Student(string name, decimal englishMarks, decimal scienceMarks, decimal socialStudiesMarks)
        {
            this._rollNumber = id++;
            this._studentName = name;
            this._englishMarks = englishMarks;
            this._scienceMarks = scienceMarks;
            this._socialStudiesMarks = socialStudiesMarks;
            this._totalMarks = englishMarks + scienceMarks + socialStudiesMarks;
        }
        public int RollNumber
        {
            get
            {
                return this._rollNumber;
            }
        }
        public string printMarksheet()
        {
            return string.Format("Student Marksheet:\nStudent RollNumber: {0}\nStudent Name: {1}\nEnglish Marks: {2}\nScience Marks: {3}\nSocialStudies Marks: {4}\nTotal Marks: {5}", this._rollNumber, this._studentName, this._englishMarks, this._scienceMarks, this._socialStudiesMarks, this._totalMarks);
        }
    }
}
