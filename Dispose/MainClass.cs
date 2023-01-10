using System;
namespace Dispose
{
    class MainClass
    {
        //static void M()
        //{

        //    Class1[] c = new Class1[10];
        //    for (int i = 0; i < 10; i++)
        //    {
        //        using (c[i] = new Class1())
        //        {

        //        }
        //        System.Threading.Thread.Sleep(100);
        //    }
        //}
        static void Main()
        {
            Class1[] c = new Class1[10];
            for (int i = 0; i < 10; i++)
            {
                using (c[i] = new Class1())
                {

                }
                System.Threading.Thread.Sleep(100);
            }
            //M();

            System.Threading.Thread.Sleep(100);
            GC.Collect();

            System.Threading.Thread.Sleep(100);
            Console.WriteLine("--------------------------------------------------");
        }

    }
}