
using System;
using System.Collections;

class MainClass
{
    public static IEnumerable GetAllUsers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }
    static void Main()
    {
        foreach(int i in GetAllUsers())
        {
            Console.WriteLine(i);
        }
        string name = "Alok";
        IEnumerable e = name;
        IEnumerator ie = e.GetEnumerator();
        while (ie.MoveNext())
        {
            Console.WriteLine(ie.Current);
        }
        ie.Reset();
        foreach(char c in name)
        {
            Console.WriteLine(c);
        }
    }
}