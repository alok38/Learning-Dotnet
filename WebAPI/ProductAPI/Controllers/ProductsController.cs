using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductAPI.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/values
        Product[] products = new Product[]
       {
            new Product{Id = 1, Name = "Soup",Category="Groceries",Price=10},
            new Product{Id = 2, Name = "Yo-Yo",Category="Toys",Price=20},
            new Product{Id = 3, Name = "Hammer",Category="Hardware",Price=30},
       };
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        public Product GetProductByPrice(int Price)
        {
            var product = products.FirstOrDefault((p) => p.Price == Price);
            if (product == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return product;
        }
        public Product GetProductById(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return product;
        }

    }
}

