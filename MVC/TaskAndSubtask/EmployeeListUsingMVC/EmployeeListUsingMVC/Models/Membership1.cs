using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeListUsingMVC.Models
{   [Table("Membership1")]
    public class Membership1
    {   [Key]
        public int id { get; set; }
        public string txtlogin { get; set; }
        public string txtpassword { get; set; }


    }
}