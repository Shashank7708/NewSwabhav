using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LoginAndLogoutInEntityFramework.Models
{   [Table("Contact")]
    public class Contact
    {   [Key]
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int phoneno { get; set; }
        public string address { get; set; }


    }
}