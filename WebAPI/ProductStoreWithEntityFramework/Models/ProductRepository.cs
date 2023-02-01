using ProductStoreWithEntityFramework.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductStoreWithEntityFramework.Models
{
  
        public class ProductRepository : IProductRepository
        {
            public List<Product> products = new List<Product>();
            private int _nextId = 1;
            public MyDAL prod;
        public ProductRepository()
        {
             prod = new MyDAL();
        }
            public Product Add(Product item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                item.Id = _nextId++;
                prod.Products.Add(item);
                prod.SaveChanges();
                return item;
            }
            public Product Get(int id)
            {
                return prod.Products.Find(id);
            }
            public IEnumerable<Product> GetAll()
            {
                return prod.Products;
            }
            public void Remove(int id)
            {
            prod.Products.Remove(prod.Products.Find(id));
                prod.SaveChanges();
                
            }
            public bool Update(int id,Product item)
            {
                 if(item == null)
                  {
                      throw new ArgumentNullException();
                  }
                
                Product found = prod.Products.Find(id);
                
              found.Name = item.Name;
              found.Category = item.Category;
              found.Price = item.Price;
                prod.SaveChanges();
                return true;
            }








        }
}