using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactAndAddressInMvc.Models
{   [Table("Address")]
    public class Address
    {   [Key]
        public int Id { get; set; }
        public string address { get; set; }
        public virtual Contact Contact { get; set; }
    }
}