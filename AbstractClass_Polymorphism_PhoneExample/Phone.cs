using System;


namespace AbstractClass_Polymorphism_PhoneExample
{
    abstract class Phone
    {
        static int id = 101;
        protected int imeiNumber;
        protected string processor;
        protected int ram;
        protected int storage;
        public int Ram
        {
            get
            {
                return this.ram;
            }
        }
        public int Storage
        {
            get
            {

                return this.storage;
            }
        }
        public Phone(string processor, int ram, int storage)
        {
            imeiNumber = id++;
            this.processor = processor;
            this.ram = ram;
            this.storage = storage;
        }
        public string printPhoneDetails()
        {
            return string.Format("Phone Details:\nIMEI Number: {0}\nProcessor: {1}\nRam: {2}\nStorage: {3}\n---------------------------", this.imeiNumber, this.processor, this.ram, this.storage);
        }
        public abstract int calculatePrice();
    }
}
