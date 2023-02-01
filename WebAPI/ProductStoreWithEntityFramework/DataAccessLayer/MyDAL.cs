using ProductStoreWithEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductStoreWithEntityFramework.DataAccessLayer
{
    public class MyDAL : DbContext 
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("TblProducts");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
    }
}