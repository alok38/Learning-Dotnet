using System;

public class MainClass
{
    static void M(int i, string s, params byte[] j)
    {
        foreach (byte b in j)
        {
            Console.Write(b + " ");
        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        byte[] b = { 1, 2, 3, 4, 5, 6, 7 };
        M(10, "a", b);
        M(2, "b", 1, 2, 3, 10, 100, 200);
    }
}
