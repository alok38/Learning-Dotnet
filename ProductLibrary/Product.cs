using PrintingServiceLib;
namespace ProductLibrary
{
    public class Product
    {
        private int _prodId;
        private string _name;
        public Product(int id, string name)
        {
            this._prodId = id;
            this._name = name;
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product id: {0}", this._prodId);
            Console.WriteLine("Product name: {0}", this._name);
        }
        public void UseService()
        {
            PrintDelegate d = new PrintDelegate(DisplayProductDetails);
            PrintingService.Print(d);
        }
    }
}