using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCDataLayerStart.Models;

namespace MVCDataLayerStart.DataAccessLayer
{
    public class EmployeeContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblMyEmployees");
            base.OnModelCreating(modelBuilder);
        }
        //DbSet will represent all te Employees that can be queried from the databse
        public DbSet<Employee> Employees { get; set; }
    }
}