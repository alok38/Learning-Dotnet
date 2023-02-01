using CustomerAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerAPI.DataAccessLayer
{
    public class MyDAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("TblCustomers");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }
    }
}