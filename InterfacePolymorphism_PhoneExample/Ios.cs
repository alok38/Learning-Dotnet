using System;

namespace InterfacePolymorphism_PhoneExample
{
    class Ios : IPhone
    {
        public string call(int number)
        {
            return string.Format("{0} is being called by an  Ios phone!", number);
        }
        public string switchOff()
        {
            return string.Format("Your Ios phone has been switched off!");
        }
        public string switchOn()
        {
            return string.Format("Your Ios phone has been switched on!");
        }
    }
}
