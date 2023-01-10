

using System;
using System.Collections.Generic;
namespace CollectionInitializer
{

    public class MainClass
    {
        public static void Main(string[] args)
        {
            List<Person> personList = new List<Person>{
           new Person {Age = 23,Name = "Alok"},
           new Person {Name = "blok"}
       };//CollectionInitializer
            foreach (Person p in personList)
            {
                Console.WriteLine("Name={0},Age={1}", p.Name, p.Age);
            }
        }
    }
}