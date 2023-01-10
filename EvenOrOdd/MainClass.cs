using System;

public class MainClass
{
    static bool evenOrOdd(int number)
    {
        if(number %2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter a Number: ");
        number = int.Parse(Console.ReadLine());
        if (evenOrOdd(number))
        {
            Console.WriteLine(number + " is Even Number");
        }
        else
        {
            Console.WriteLine(number + " is Odd Number");
        }
    }

}