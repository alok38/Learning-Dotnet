using System;

namespace InterfacePolymorphism_PhoneExample
{
    class Android : IPhone
    {
        public string call(int number)
        {
            return string.Format("{0} is being called by an Android phone!", number);
        }
        public string switchOff()
        {
            return string.Format("Your Android phone has been switched off!");
        }
        public string switchOn()
        {
            return string.Format("Your Android phone has been switched on!");
        }
    }
}
