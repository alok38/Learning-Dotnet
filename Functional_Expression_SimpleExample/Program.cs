public delegate void PrintDelegate();
public class MainClass
{
    static void SayHello()
    {
        Console.WriteLine("Hello");
    }
    public static void Main()
    {
        PrintDelegate p = new PrintDelegate(SayHello);
        p();
         p += delegate ()
        {
            Console.WriteLine("hello");
        };
        p += () =>
        {
            Console.WriteLine("hello");
        };
       foreach(PrintDelegate pa in p.GetInvocationList())
        {
            Console.WriteLine(pa.DynamicInvoke());
        }
    }
}
