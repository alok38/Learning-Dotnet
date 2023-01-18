using CustomerMVCAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerMVCAssignment.DataAccesLayer
{
    public class CustomerContext : DbContext
    {
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Customer>().ToTable("TblMyCustomers");
                base.OnModelCreating(modelBuilder);
            }
            //DbSet will represent all te Employees that can be queried from the databse
            public DbSet<Customer> Customers { get; set; }
        
    }
}