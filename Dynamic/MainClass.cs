namespace Dynamic
{
    class MainClass
    {
        static dynamic x;
        public static object GetCustomer()
        {
            return new Customer();
        }
        public static object GetProduct()
        {
            return new Product();
        }
        static void Main()
        {
            MainClass.x = 100;
            Console.WriteLine(MainClass.x);
            dynamic obj;
            obj = GetCustomer();
            obj.CustomerId = 101;
            obj.customerName = "Alok";
            Console.WriteLine(obj.CustomerId + " ");
            Console.WriteLine(obj.customerName);
            Console.WriteLine(obj.SayHello("Alok"));
            Console.WriteLine(obj.GetType());
            Console.WriteLine("--------------------");



            obj = GetProduct();
            obj.ProductId = 102;
            obj.ProductName = "Car";
            Console.WriteLine(obj.ProductId + " ");
            Console.WriteLine(obj.ProductName);
            Console.WriteLine(obj.SayHello("Car"));
            Console.WriteLine(obj.GetType());
            Console.WriteLine("--------------------");




            Customer cust = new Customer();
            dynamic dycust = cust;
            dycust.CustomerId = 1001;
            Console.WriteLine(cust.CustomerId);



            Customer newRef = dycust;
            newRef.CustomerId = 1002;
            Console.WriteLine(dycust.CustomerId);
            cust.customerName = "Alok";
            Console.WriteLine(newRef.customerName);
            Console.WriteLine("-------------------------");



            int id = cust.customerId;//Returns dynamic so conversion occurs
            dynamic name = cust.customerName; //No conversion occurs
            object o = cust.customerName;//Conversion Occurs
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(o);








        }
    }
}