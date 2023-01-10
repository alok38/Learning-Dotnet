using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter 1st word: ");
        string a = Console.ReadLine();
        Console.WriteLine("enter 2nd word: ");
        string b = Console.ReadLine();
        if (a.Equals(b))
        {
            Console.WriteLine("they are same words");
        }
        else
        {
            Console.WriteLine("they are different words");
        }
    }
}