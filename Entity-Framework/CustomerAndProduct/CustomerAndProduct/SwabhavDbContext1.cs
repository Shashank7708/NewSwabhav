using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndProduct
{
    class SwabhavDbContext1: DbContext
    {
        public SwabhavDbContext1() : base("SwabhavDbContext1")
        {

        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
