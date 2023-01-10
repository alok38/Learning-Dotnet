using System.Data.Entity;

namespace EFCodeFirst
{
    class CustomerContext : DbContext
    {
        public CustomerContext() : base("MyDbConn")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CustomerContext>());
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
