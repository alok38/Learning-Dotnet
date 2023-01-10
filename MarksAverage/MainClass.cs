using System;

public class MainClass
{
    static int average(int a,int b,int c)
    {
        return (a + b + c)/3;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter Marks of C#: ");
        int marks1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Marks of Asp.net: ");
        int marks2 = int.Parse(Console.ReadLine());
        Console.Write("Enter Marks of SqlServer: ");
        int marks3 = int.Parse(Console.ReadLine());
        int avg = average(marks1, marks2, marks3);
        if(avg >= 50)
        {
            System.Console.WriteLine("Your Average is: {0} You have Passed", avg);
        }
        else
        {
            System.Console.WriteLine("Your Average is: {0} You have Failed", avg);
        }
    }

}