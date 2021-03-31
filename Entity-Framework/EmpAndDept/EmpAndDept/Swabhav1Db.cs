using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndDept
{
    class Swabhav1Db:DbContext
    {
        public DbSet<Dept> Departments { get; set; }
        public DbSet<Emp> Employees { get; set; }
        public Swabhav1Db() : base("name=Swabhav1Db")
        {

        }
    }
}
