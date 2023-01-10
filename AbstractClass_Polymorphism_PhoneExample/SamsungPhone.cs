﻿using System;

namespace AbstractClass_Polymorphism_PhoneExample
{
    class SamsungPhone : Phone
    {
        private int _basePrice;

        public SamsungPhone(string processor, int ram, int storage, int price) : base(processor, ram, storage)
        {
            this._basePrice = price;
        }
        public override int calculatePrice()
        {
            int totalprice;
            if (this.Ram > 6 && this.Storage > 128)
            {
                totalprice = _basePrice + 50000;
            }
            else
            {
                totalprice = _basePrice + 20000;
            }
            return totalprice;
        }
    }
}
