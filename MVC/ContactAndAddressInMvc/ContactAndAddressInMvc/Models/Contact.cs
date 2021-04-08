using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactAndAddressInMvc.Models
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int contactNo { get; set; }
        public virtual List<Address> Addresseslist { get; set; }
        public Contact()
        {
            Addresseslist = new List<Address>();
        }


    }
}