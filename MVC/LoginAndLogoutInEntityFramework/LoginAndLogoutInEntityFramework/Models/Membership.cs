using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LoginAndLogoutInEntityFramework.Models
{   [Table("Membership")]
    public class Membership
    {   [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }


    }
}