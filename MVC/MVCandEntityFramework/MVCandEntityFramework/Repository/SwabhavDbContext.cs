using MVCandEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCandEntityFramework.Repository
{
    public class SwabhavDbContext:DbContext
    {
        public SwabhavDbContext() : base("SwabhavDbContext")
        {

        }
        public DbSet<Contact> contacts { get; set; }
    }
}