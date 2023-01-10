using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_EntityFramework
{
    public class MainClass
    {
        static NorthwindEntities NWEntities = new NorthwindEntities();
        static IEnumerable<Product> beverages;

        static void SelectProducts()
        {
            beverages = from p in NWEntities.Products
                        where p.Category.CategoryName == "Beverages"
                        orderby p.ProductName
                        select p;
            foreach(Product prod in beverages)
            {
                Console.WriteLine(prod.ProductName);

            }
            Console.WriteLine("Total No Of Products: "+ beverages.Count());
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        static void SelectOrderDetails()
        {
            var pro = from od in NWEntities.Order_Details
                      where od.Product.ProductID == 11
                      select od;
            foreach(Order_Detail o in pro)
            {
                Console.WriteLine(o.OrderID);
            }
            Console.WriteLine("Total Number: " + pro.Count());

            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        static void AddProduct()
        {
            Product newProduct = new Product { ProductName = "new Test Product"};
            NWEntities.Products.Add(newProduct);
            NWEntities.SaveChanges();
            Console.WriteLine("Added a new product with name 'new Test Product'");
        }
        static void UpdateProduct()
        {
            Product bev1 = beverages.ElementAtOrDefault(10);
            Console.WriteLine(bev1.ProductName);
            if(bev1 != null)
            {
                decimal newPrice = (decimal)bev1.UnitPrice + 10.00m;
                Console.WriteLine("The price of {0} is {1}. Update to {2}",bev1.ProductName,bev1.UnitPrice,newPrice);
                bev1.UnitPrice = newPrice;
                NWEntities.SaveChanges();
            }
        }
        static void DeleteProduct()
        {
            IQueryable<Product> productsToDelete =
                                from p in NWEntities.Products
                                where p.ProductName == "new Test Product"
                                select p;

            if(productsToDelete.Count() > 0)
            {
                foreach(var p in productsToDelete)
                {
                    NWEntities.Products.Remove(p);
                    Console.WriteLine("Deleted Product {0}",p.ProductID);
                }
                NWEntities.SaveChanges();
            }
        }
        static void JoiningTwoTables()
        {
            var categoryProducts =
                from c in NWEntities.Categories
                join p in NWEntities.Products
                on c.CategoryID equals p.CategoryID
                into productsByCategory
                select new
                {
                    c.CategoryName,
                    productCount = productsByCategory.Count(),
                };
            foreach(var cp in categoryProducts)
            {
                Console.WriteLine("There are {0} products in {1}",cp.productCount,cp.CategoryName);
            }
            Console.WriteLine("---------------------------------------------------------------------------------");


            //Querying a view we have not added view while adding tables that is why commenting 

            //var currentProducts = from p in NWEntities.Current_Product_Lists
            //                      select p;
            //foreach(var p in currentProducts)
            //{
            //    Console.WriteLine("Product Id{0} Product Name{1} ",p.ProductID,p.ProductName);
            //}
        }
        static void Main(string[] args)
        {
           //SelectProducts();
            // SelectOrderDetails();
            // AddProduct();
            // UpdateProduct();
            //DeleteProduct();
            JoiningTwoTables();
        }
    }
}
