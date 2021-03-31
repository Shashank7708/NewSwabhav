using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDb
{
    class SwabhavDbContext:DbContext
    {
        public SwabhavDbContext() : base("SwabhavDbContext1") 
        { 
        }
        public DbSet<Contact> contacts { get; set; }
    }
}
