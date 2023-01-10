using System;
using System.Collections.Generic;
using System.Linq;

namespace CrossJoinQuery
{
    class MainClass
    {
        static void Main()
        {
            char[] upperCase = { 'A', 'B', 'C' };
            char[] lowerCase = { 'x', 'y', 'z' };

            var joinQuery1 =
                from upper in upperCase
                from lower in lowerCase
                select new { upper, lower }; //Anonymous Type created

            //Execute te query
            Console.WriteLine("Cross join: ");
            foreach(var pair in joinQuery1)
            {
               // Console.WriteLine(pair);
                Console.WriteLine("{0} is matched to {1}",pair.upper,pair.lower);
            }
            Console.WriteLine("--------------------------------------------");

            var joinQuery2 = 
                from upper in upperCase
                where upper != 'B'
                from lower in lowerCase
                select new { lower, upper };
            Console.WriteLine("filtered non-equijoin");
            foreach(var pair in joinQuery2)
            {
                Console.WriteLine("{0} is matched with {1}",pair.lower,pair.upper);
            }
        }
    }
}