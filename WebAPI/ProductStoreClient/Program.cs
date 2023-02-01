using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
           
            client.BaseAddress = new Uri("http://localhost:49986/");
            HttpResponseMessage response;
            ////Create new Product
            var gizmo = new Product() { Name = "biz", Price = 180, Category = "widget" };
            Uri gizmoUri = null;

            response = client.PostAsJsonAsync("api/Product/PostProduct/", gizmo).Result;
            if (response.IsSuccessStatusCode)
            {
                gizmoUri = response.Headers.Location;
                Console.WriteLine(gizmoUri);
            }
            else
            {
                Console.WriteLine("{0}  ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("---------------------------------------------------------------------");

            //Add an accept header for json format            
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //Get a product by Id      
            response = client.GetAsync("api/Product/GetProduct/1").Result;
            if (response.IsSuccessStatusCode)
            {
                var product = response.Content.ReadAsAsync<Product>().Result;
                Console.WriteLine("{0}\t{1}\t{2}", product.Name, product.Price, product.Category);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine(".........................................");
            response = client.GetAsync("api/Product/GetAllProducts/").Result;
            if (response.IsSuccessStatusCode)
            {
                var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result; foreach (var p in products)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", p.Name, p.Price, p.Category);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("-----------------------------------");
            gizmo.Price = 99.9;
            response = client.PutAsJsonAsync(gizmoUri.PathAndQuery, gizmo).Result;
            Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            Console.WriteLine("------------------------------");
            Console.Write("Enter Product Id to Update");
            int id = int.Parse(Console.ReadLine());
            response = client.GetAsync("api/Product/GetProduct/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var product = response.Content.ReadAsAsync<Product>().Result;
                product.Price = 110;
                response = client.PutAsJsonAsync("api/Product/GetProduct/" + id, product).Result;
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("------------------------------");


            //Delete a product
            response = client.DeleteAsync("api/Product/DeleteProduct/6").Result;
            Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);

            Console.WriteLine("***************************************************************************");
            //List All Products.
            response = client.GetAsync("api/Product/GetAllProducts").Result;  //Blocking call
            if (response.IsSuccessStatusCode)
            {
                //Parse the response body. Blocking!
                var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                foreach (var product in products)
                {
                    Console.WriteLine("{0}\t{1};\t{2}", product.Name, product.Price, product.Category);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
}
