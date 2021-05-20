using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08
{
    class OrderContext:DbContext
    {
        public OrderContext() : base("OrderContext")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> Details { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
