using LoginAndLogoutInEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginAndLogoutInEntityFramework.Repository
{
    public class UserDbContext:DbContext
    {
        public UserDbContext() : base("SwabhavDbContext")
        {

        }

        public DbSet<Membership> membership { get; set; }

    }
}