using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Serialization
{
    [Serializable]
    public class Products
    {
        public int ProductId;
        public string Name;
        [NonSerialized]
        public float Rate;
        public int stock;
        public int check;



        public Products()
        {



        }
        public Products(int pid, string pname, float prate, int pstock, int pcheck)
        {
            ProductId = pid;
            Name = pname;
            Rate = prate;
            stock = pstock;
            check = pcheck;
        }



        public int Check
        {
            get
            {
                return check;
            }
        }
        public int Stock
        {
            get
            {
                return stock;
            }
        }



    }
}
