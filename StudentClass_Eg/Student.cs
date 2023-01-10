using System;


using System;




namespace StudentClass_Eg
{
    class Student
    {
        private static int id = 101;
        private int _rollNumber;
        private string _name;
        private int _class;
        private int _sem;
        private string _branch;
        public Student(string name, int cl, int sem, string branch)
        {
            this._rollNumber = id++;
            this._name = name;
            this._class = cl;
            this._sem = sem;
            this._branch = branch;
        }
        public int RollNo
        {
            get
            {
                return _rollNumber;
            }
        }
        private int[] Marks = new int[5];
        public void MarksSetter(int[] arr)
        {
            Marks[0] = arr[0];
            Marks[1] = arr[1];
            Marks[2] = arr[2];
            Marks[3] = arr[3];
            Marks[4] = arr[4];

        }
        public string ReturnMarks()
        {
            return string.Format("Marks1: {0}\nMarks2: {1}\nMarks3: {2}\nMarks4: {3}\nMarks5: {4}\n", Marks[0], Marks[1], Marks[2], Marks[3], Marks[4]);
        }



        public string DisplayResult()
        {
            int sum = 0;
            bool pass = true;
            for (int i = 0; i < 5; i++)
            {
                sum += Marks[i];
                if (Marks[i] < 35)
                {
                    pass = false;
                }
            }
            int avg = sum / 5;
            if (avg < 50)
            {
                pass = false;
            }
            if (pass)
            {
                return String.Format("You have passed,Your Average is: {0}", avg);
            }
            else
            {
                return String.Format("You have failed,Your Average is: {0}", avg);
            }



        }
        public string DisplayData()
        {
            return string.Format("RollNumber: {0}\nName: {1}\nClass: {2}\nSem: {3}\nBranch: {4}\nMarks1: {5}\nMarks2: {6}\nMarks3: {7}\nMarks4: {8}\nMarks5: {9}\nResult: {10}", this._rollNumber, this._name, this._class, this._sem, this._branch, Marks[0], Marks[1], Marks[2], Marks[3], Marks[4], this.DisplayResult());
        }




    }
}