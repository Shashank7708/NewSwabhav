using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactAndAddressInMvc.ViewModel
{
    public class AddressVm
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public int Contact { get; set; }
    }
}