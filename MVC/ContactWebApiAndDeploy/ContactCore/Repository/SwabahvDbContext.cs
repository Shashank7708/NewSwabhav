using ContactCore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore.Repository
{
   class SwabahvDbContext:DbContext
    {
       public SwabahvDbContext() : base("SwabahvDbContext")
        {
            var ensureDLLIsCopied =
             System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<Contact> contacts { get; set; }
    }
}
