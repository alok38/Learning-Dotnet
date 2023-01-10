
public class MainClass
{
    static void SwapData<t>(t a,t b)
    {
        t temp;
        temp = a; a = b; b = temp;
        Console.WriteLine("after swap: a: " + a + "\n b: " + b);
    }
    //static void SwapName(string a, string b)
    //{
    //    string temp;
    //    temp = a; a = b; b = temp;
    //    Console.WriteLine("after swap : a:"+a+"\n b: "+b);
    //}
    public static void Main(string[] args)
    {
        int a = 10; int b = 12;
        string c = "alok"; string d = "blok";
        Console.WriteLine("before swap a: "+a+"\n b: "+b);
        SwapData<int>(10, 12);
        Console.WriteLine("before swap a: "+c + "\n b: " + d);
        SwapData<string>(c, d);
    }

}