using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Word: ");
        string s = Console.ReadLine();
        char[] arr = s.ToCharArray();
        string a = "";
        for(int i = arr.Length - 1; i >= 0; i--)
        {
            a += arr[i];
        }
        
        Console.WriteLine("reverse of your word is: "+a);
    }
}