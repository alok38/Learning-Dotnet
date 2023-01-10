using System;
namespace InterfaceImplementation_Assignment
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            ClassTwo c2 = new ClassTwo();
            c2.MethodOne();
            c2.MethodTwo();
            c2.MethodThree();
            c2.MethodFour();

            ClassOne c1 = new ClassTwo();
            c1.MethodOne();
            c1.MethodTwo();
            c1.MethodThree();



        }
    }
}