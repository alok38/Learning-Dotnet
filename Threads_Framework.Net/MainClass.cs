using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_Framework.Net
{
    using System;
    using System.Threading;

    public class MainClass
    {
        public static void M()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Thread M:{0}", i + 1);
            }
        }
        public static void N()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Thread Another:{0}", i + 1);
            }
        }
        public static void P(object s)
        {
            Console.WriteLine("Hello " + (string)s);
        }
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(M));
            Thread t2 = new Thread(N);
            t1.IsBackground = true;
            t1.Start();
            t2.Start();
            Console.WriteLine("tells t1 is background: " + t1.IsBackground);
            t1.Abort();
            Console.WriteLine("t1 is alive? : " + t1.IsAlive);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Main:{0}", i);

            }
            t1.Join();
            Console.WriteLine("Hello Back in Main");
            Thread t3 = new Thread(new ParameterizedThreadStart(P));

            t3.Start("alok");


            Console.WriteLine("--------------------------");
            Console.WriteLine("t1 is alive? : " + t1.IsAlive);
        }

    }
}
