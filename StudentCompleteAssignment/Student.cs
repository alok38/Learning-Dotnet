using System;

namespace PartialStudentClassAssignment
{
    [Serializable]
    public partial  class Student
    {
        private static int id = 101;
        public readonly int rollNumber;
        public readonly string _name;
        public readonly int _marks;
    }
}
