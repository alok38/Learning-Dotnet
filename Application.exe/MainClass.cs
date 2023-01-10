using EmployeeLibrary;
using ProductLibrary;
using CustomerLibrary;
class MainClass
{
    static void Main()
    {
        Customer cust = new Customer(101, "Alok");
        Product prod = new Product(103, "box");
        Employee emp = new Employee(1056, "Blok",10000,8000,9000);
        cust.AvailService();
        Console.WriteLine("-----------------------------");
        prod.UseService();
        Console.WriteLine("------------------------------");
        emp.GenerateSalarySlip();
    }
}