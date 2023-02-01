using MVCProduct.Models;
using MVCProduct.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCProduct.Controllers
{
    public class ProductController : Controller
    {
        HttpClient client;
        HttpResponseMessage response;
        // GET: Product
         List<Product> products1 = new List<Product>();
         ProductRecordsViewModel prvm = new ProductRecordsViewModel();
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult GetProducts()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49986/");
            response = client.GetAsync("api/Product/GetAllProducts/").Result;
           
               var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
              
                foreach (var p in products)
                {
                    Product prod = new Product();
                    prod.Id = p.Id;
                    prod.Name = p.Name;
                    prod.Price = p.Price;
                    prod.Category = p.Category;

                    products1.Add(prod);
                }
                prvm.MyProducts = products1;
                return View(prvm);
            
            
        }
        public ActionResult CreateProduct()
        {
            return View();
        }

        public ActionResult CreateProducts(Product p)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49986/");
            Product gizmo = new Product();
            gizmo.Id = p.Id;
            gizmo.Name = p.Name;
            gizmo.Price = p.Price;
            gizmo.Category = p.Category;
            response = client.PostAsJsonAsync("api/Product/PostProduct", gizmo).Result;
            return RedirectToAction("GetProducts");
        }
        public ActionResult DeleteProduct()
        {
            return View();
        }
        public ActionResult DeleteProducts(int id)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49986/");
            response = client.DeleteAsync("api/Product/DeleteProduct/" + id).Result; return RedirectToAction("GetProducts");
        }
        public ActionResult UpdateProductById(int id, Product product)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49986/");
            response = client.GetAsync("api/Product/GetProduct/" + id).Result;
            //Parse the response body blocking
            Product prod = response.Content.ReadAsAsync<Product>().Result;
            prod.Price = product.Price;
            prod.Name = product.Name;
            prod.Category = product.Category;
            // product.Price = 110;
            response = client.PutAsJsonAsync("api/Product/PutProduct/" + id, prod).Result;
            return RedirectToAction("GetProducts");
        }
        public ActionResult UpdateProduct()
        {

            
           return View();
        }


    }
}