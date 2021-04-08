using EmployeeListUsingMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeListUsingMVC.Repository
{
    public class UserRepo:DbContext
    {

        public UserRepo() : base("SwabhavDbContext1")
        {

        }

        public DbSet<Membership1> memberships { get; set; }


    }
}