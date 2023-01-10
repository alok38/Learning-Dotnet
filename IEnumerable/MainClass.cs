
using System;
using System.Collections;

public class MainClass
{
    public static void Main(string[] args)
    {
        int[] intArray = new int[5] { 1, 2, 3, 4, 5 };
        foreach(int i in intArray)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-------------------------------------------------------");
        IEnumerator t = intArray.GetEnumerator();
        while (t.MoveNext())
        {
            Console.WriteLine(t.Current);
        }
        t.Reset();
        Console.WriteLine("--------------------------------------------------------");
        IEnumerable en = intArray;
        foreach(int i in en)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("---------------------------------------------------------");
        t = en.GetEnumerator();
        while (t.MoveNext())
        {
            Console.WriteLine(t.Current);
        }
        t.Reset();
    }
}