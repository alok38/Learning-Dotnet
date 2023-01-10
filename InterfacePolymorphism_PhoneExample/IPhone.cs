using System;

namespace InterfacePolymorphism_PhoneExample
{
    interface IPhone
    {
        string call(int number);
        string switchOff();
        string switchOn();
    }
}
