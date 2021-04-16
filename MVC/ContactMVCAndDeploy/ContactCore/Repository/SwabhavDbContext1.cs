using ContactCore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore.Repository
{
   public class SwabahvDbContext1 : DbContext
    {
        public SwabahvDbContext1() : base("SwabahvDbContext1")
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServer.SqlProviderServices.Instance;
         
        }

        public DbSet<Contact> contact { get; set; }
        
    }
}
