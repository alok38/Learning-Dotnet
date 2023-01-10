namespace Customer_lib
{
    public class Customer
    {
        private int _id;
        private string _name;

        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
        }   
        public void Display()
        {
            Console.WriteLine("Customer Details:\n1.Id: {0}\n2.Name: {1}",_id,_name);
        }
    }
}