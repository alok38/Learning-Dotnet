namespace Employee_lib
{
    public class Employee
    {

        private int _id;
        private string _name;

        public Employee(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public void Display()
        {
            Console.WriteLine("Employee Details:\n1.Id: {0}\n2.Name: {1}", _id, _name);
        }
    }
}