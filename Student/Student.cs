namespace Student_lib
{
    public class Student
    {

        private int _id;
        private string _name;

        public Student(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public void Display()
        {
            Console.WriteLine("Student Details:\n1.Id: {0}\n2.Name: {1}", _id, _name);
        }
    }
}