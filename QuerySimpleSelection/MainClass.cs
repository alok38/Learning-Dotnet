using System.Collections.Generic;
using System.Linq;
namespace QuerySimpleSelection
{
    class MainClass
    {
        static void Main()
        {
            //select numbers less than 5 and when divided by two have a remainder of 0.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //create the query
            //lowNums is an IEnumerable <int>

            var lowNums = from num in numbers
                          where num < 5 && num % 2 == 0
                          select num;
            //Execute the Query
            foreach(int i in lowNums)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("Sum: "+ lowNums.Sum());
        }
    }
}