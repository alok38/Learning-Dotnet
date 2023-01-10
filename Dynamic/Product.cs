using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dynamic
{
    class Product
    {
        public string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public Product()
        {
        }
        public Product(int pId, string pName)
        {
            this.ProductId = pId;
            this.productName = pName;
        }
        public string SayHello(string name)
        {
            return "Hello :" + name;
        }
    }
}