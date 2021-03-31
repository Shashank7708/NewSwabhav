using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAndAddresUsingEntityFrameWork
{
    class SwabhavDbContext3:DbContext
    {
        public DbSet<Contact> contact { get; set; }
        public DbSet<Address> address { get; set; }
        public SwabhavDbContext3() : base("SwabhavDbContext3")
        {

        }

    }
}
