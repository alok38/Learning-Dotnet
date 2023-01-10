using System;
namespace PartialMethods
{
    class MainClass
    {
        static void Main()
        {
            MyPartialClass p = new MyPartialClass();
            p.CallNonStaticMethod();
            MyPartialClass.CallStaticMethod();
        }
    }
}