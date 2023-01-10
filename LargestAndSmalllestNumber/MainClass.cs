using System;

public class MainClass
{
    static void largeAndSmall(int a,int b,int c)
    {
        int largest = a;
        int smallest = c;
        if(b > largest )
        {
            largest = b;
        }
        if(c > largest){
         largest = c;
        }
         if(a < smallest)
        {
         smallest = a;
        }
         if(b < smallest)
        {
             smallest=b;    
        }
        Console.WriteLine("Largest Number is: {0}\nSmallest Number is: {1}",largest,smallest);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter 1st Number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd Number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 3rd Number: ");
        int c = int.Parse(Console.ReadLine());
        largeAndSmall(a,b,c);

    }

}