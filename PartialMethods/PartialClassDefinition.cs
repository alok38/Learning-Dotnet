


    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    namespace PartialMethods
    {
        partial class MyPartialClass
        {
            partial void M()
            {
                Console.WriteLine("Partial Method M");
           
            }
            static partial void N()
            {
                Console.WriteLine("Static Partial method implemented");
            }
            public static void CallStaticMethod()
            {
                N();
            }
            public void CallNonStaticMethod()
            {
                this.M();
           
            }
        }
    }

