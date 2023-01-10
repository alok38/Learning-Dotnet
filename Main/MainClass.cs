using Student_lib;
using Customer_lib;
using Employee_lib;
using Printerlib;
using DelegateLibrary;


public class MainClass
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee(101, "alok");
        Student stu = new Student(401, "blok");
        Customer cus = new Customer(1001, "clok");
        PrintDelegate p = new PrintDelegate(emp.Display);
        p += stu.Display;
        p += cus.Display;
        Printer.print(p);
    }
}