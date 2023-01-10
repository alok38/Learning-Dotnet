using System;


namespace Interface_Implementation_Example
{
    class class1 : Interface1, Interface2
    {
        void Interface1.M()
        {
            Console.WriteLine("Interface1 M explicit implementation");
        }
        public void M()
        {
            Console.WriteLine("Interface2 M implementation");
        }
        public void N()
        {
            Console.WriteLine("common impl");
        }
    }
}
