using System;
using System.Linq;

class MainClass
{
    static void Main()
    {
        //Three Parts of a Linq Query:
        //1.DataSource
        int[] numbers = new int[7] { 0,1, 2, 3,4,5,6 };
        //2.Query Creation
        //numQuery is an IEnumerabl<int>
        var numQuery =
            from num in numbers
            where (num % 2) == 0
            select num;

        //3.Query execution 
        foreach(int n in numQuery)
        {
            Console.WriteLine("{0,2}",n);
        }
        Console.WriteLine("-----------------------------------");
        //Another Example
        List<int> numQuery2 =
            (from num in numbers
             where (num%2) == 0
             select num).ToList();
        numQuery2.Remove(4);

        foreach(int i in numQuery2)
        {
            Console.WriteLine("{0,2}",i);
        }
        Console.WriteLine();
    }
}