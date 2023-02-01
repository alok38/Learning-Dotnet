using EmployeesDepartmentProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeesDepartmentProjectApi.DataAccessLayer
{
   
        public class MyDAL : DbContext
        {
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Employee>().ToTable("TblEmployees");
                modelBuilder.Entity<Department>().ToTable("tblDepartments");
                modelBuilder.Entity<Project>().ToTable("tblProjects");
                base.OnModelCreating(modelBuilder);
            }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Department> Departments { get; set; }
            public DbSet<Project>Projects { get; set; }
        }
    
}