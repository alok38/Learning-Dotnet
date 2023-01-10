using System;

public class MainClass
{
    static bool palindromeCheck(string s)
    {
        char[] arr = s.ToCharArray();
        for (int i = 0; i < arr.Length / 2; i++)
        {
            if (arr[i] != arr[arr.Length - i - 1])
            {
                return false;
                
            }

            
        }
        return true;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Word: ");
        string s = Console.ReadLine();
        if (palindromeCheck(s))
        {
            Console.WriteLine("palindrome");
        }
        else
        {
            Console.WriteLine("not a palindrome");
        }
       
    }
}