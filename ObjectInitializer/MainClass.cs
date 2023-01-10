using System;
namespace ObjectInitializer
{

    public class MainClass
    {
        public static void Main(string[] args)
        {
            Person p = new Person { Age = 23, Name = "Alok", City = "Bhilai" }; //ObjectInitializer
            Console.WriteLine("Age={0}\nName={1}\nCity={2}", p.Age, p.Name, p.City);
        }
    }
}