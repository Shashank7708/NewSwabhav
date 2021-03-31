using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace SimpleEntityFramework
{
    class DemoDbContext:DbContext
    {
        public DemoDbContext()
        {

        }
        public DbSet<Employee> employees { get; set; }

    }
}
