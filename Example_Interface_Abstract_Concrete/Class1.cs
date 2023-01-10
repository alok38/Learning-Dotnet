using System;


namespace Example_Interface_Abstract_Concrete
{
    abstract class class1 : Interface1
    {
        void Interface1.M()
        {
            Console.WriteLine("Interface1::M");
        }
        public abstract void N();
    }
}
