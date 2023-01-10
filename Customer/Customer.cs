using PrintingServiceLib;
namespace CustomerLibrary
{
    public class Customer
    {
        private int _custId;
        private string _custName;
        public Customer(int custId, string custName)
        {
            this._custId = custId;
            this._custName = custName;
        }
        private void Display()
        {
            Console.WriteLine("Cust Id: {0}",this._custId);
            Console.WriteLine("Cust Name: {0}", this._custName);
        }
        public void AvailService()
        {
            PrintDelegate d = new PrintDelegate(Display);
            PrintingService.Print(d);
        }
    }
}