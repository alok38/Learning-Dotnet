using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Student_Project
{
    class courseContext : DbContext
    {
        public courseContext() : base("MyConn")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<courseContext>());
        }
        public DbSet<Course> Courses { get; set; }
    }
}
