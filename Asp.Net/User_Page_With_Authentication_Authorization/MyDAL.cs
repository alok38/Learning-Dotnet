using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace User_Page_With_Authentication_Authorization
{
    class MyDAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("TblUsers");
            base.OnModelCreating(modelBuilder);
        }

        //DbSet will represent all the Users that can be queried from the database
        public DbSet<User> Users { get; set; }
    }
}