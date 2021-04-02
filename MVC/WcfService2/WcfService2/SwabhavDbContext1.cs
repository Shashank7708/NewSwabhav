using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class SwabhavDbContext1:DbContext
    {
        public SwabhavDbContext1():base("SwabhavDbContext1")
        {

        }

        public DbSet<Person> persons { get; set; }
    }
}