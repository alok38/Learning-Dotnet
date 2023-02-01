using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestEXp.Models;

namespace TestEXp
{
    public class MyDAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("tblStudent");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> students { get; set; }
    }
}