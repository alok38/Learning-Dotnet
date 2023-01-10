public delegate void PrintDelegate(ref int x);

public class MainClass
{
    //static void meth1(ref int x)
    //{
    //    Console.WriteLine(x);
    //}
    public static void Main()
    {
        PrintDelegate p = delegate (ref int x)
        {
            x = 10;
            Console.WriteLine(x);
        };
        //int a = 5;
        //PrintDelegate p = new PrintDelegate(meth1);
        //p(ref a);
        int x = 5;
        p(ref x);
        Console.WriteLine(x);
    }
}