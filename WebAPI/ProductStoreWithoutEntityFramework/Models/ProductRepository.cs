using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductStoreWithoutEntityFramework.Models
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> products = new List<Product>();
        private int _nextId = 1;



        public ProductRepository()
        {
            Add(new Product { Id = 1, Name = "Soup", Category = "Groceries", Price = 10 });
            Add(new Product { Id = 2, Name = "Yo-Yo", Category = "Toys", Price = 20 });
            Add(new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 30 });
        }



        public IEnumerable<Product> GetAll()
        {
            return products;
        }



        public Product Get(int id)
        {
            return products.Find(p => p.Id == id);
        }



        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            products.Add(item);
            return item;
        }



        public void Remove(int id)
        {
            products.RemoveAll(p => p.Id == id);
        }



        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);
            return true;
        }
    }
}
