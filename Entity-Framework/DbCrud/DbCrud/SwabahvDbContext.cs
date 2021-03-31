using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCrud
{
    class SwabahvDbContext:DbContext
    {
        public SwabahvDbContext() : base("SwabahvDbContext")
        {

        }
        public DbSet<Emp> emps { get; set; }
    }
}
