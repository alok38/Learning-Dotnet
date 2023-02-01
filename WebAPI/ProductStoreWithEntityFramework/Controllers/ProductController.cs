using ProductStoreWithEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductStoreWithEntityFramework.Controllers
{
    public class ProductController : ApiController
    {
        static readonly IProductRepository repository = new ProductRepository();
        // GET api/values
        public IEnumerable<Product> GetAllProducts()
        {
            return repository.GetAll();
        }         // GET api/values/5
        public Product GetProduct(int id)
        {
            Product item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return repository.GetAll().Where(
            p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        }         //Not the final Implementation        
        //public Product PostProduct(Product item)
        //{
        //    item = repository.Add(item);
        //    return item;
        //}
        public HttpResponseMessage PostProduct( Product item)
        {
            item = repository.Add(item);
            var response = Request.CreateResponse<Product>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi",new {id = item.Id});
            response.Headers.Location = new Uri(uri);
            return response;
        }
    public void PutProduct(int id, Product product)
    {
        
        if (!repository.Update(id,product))
        {
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        Console.WriteLine("Product got updated");
    }
    public void DeleteProduct(int id)
    {
        Product item = repository.Get(id);
        //if (item == null)
        //{
        //    throw new HttpResponseException(HttpStatusCode.NotFound);
        //}
        repository.Remove(id);
    }
}
}

