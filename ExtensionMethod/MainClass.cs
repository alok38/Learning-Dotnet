using System;
namespace ExtensionMethod
{
    class MainClass
    {
        static void Main()
        {
            string str = "1234";
            int i = str.ToInt32();
            ++i;
            Console.WriteLine(i);
        }
    }
}

