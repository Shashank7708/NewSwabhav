using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCandEntityFramework.Models
{   [Table("Contact")]
    public class Contact
    {   [Key]
        public string fname { get; set; }
        public string lname { get; set; }

        public int phoneno { get; set; }
        public string address { get; set; }
    }
}