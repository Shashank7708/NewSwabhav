using ContactAndAddressInMvc.Models;
using System.Data.Entity;

namespace ContactAndAddressInMvc.Repository
{
    public class SwabhavDbContext1 : DbContext
    {

        public SwabhavDbContext1() : base("SwabhavDbContext1")
        {

        }

        public DbSet<Contact> contact { get; set; }
        public DbSet<Address> address { get; set; }


    }
}