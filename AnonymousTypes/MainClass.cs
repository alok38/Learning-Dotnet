

using System;
//Anonymous Types
public class MainClass
{
    public static void Main(string[] args)
    {
        var Person = new { Name = "Alok", Age = 23 };//Anonymous Type is created
        //Person.Name = "Ram"; Not allowed because Anonymous Type creates readonly property
        Console.WriteLine("Name={0},Age={1}", Person.Name, Person.Age);
        var p = Person; //Anonymous Types are reference types that derive directly from object
        Console.WriteLine("Name={0},Age={1}", p.Name, p.Age);
        var Per = new { Name = "Alok", Age = 23 };
        if (p.Equals(Per))
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine("Different");
        }
        if (Object.ReferenceEquals(p, Per))
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine("Different");
        }
        if (p == Per)
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine("Different");
        }
    }
}