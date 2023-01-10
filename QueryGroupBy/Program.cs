using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryGroupBy
{
    class MainClass
    {
        static void Main()
        {
            //the gruop clause returns a sequence of IGrouping of (TKey,TElement) objects that contain zero or more items that match
            string[] names = { "Alok", "Anon", "Bnon", "Cnon", "Dnon", "Bans", "Aplo", "circ" };
            var namegroups = from n in names //like foreach(string n in names)
                             group n by n[0];

            foreach(var group in namegroups)
            {
                Console.WriteLine("names that start with letter {0}: ",group.Key);
                foreach(string name in group)
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}