using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactMVCAndDeploy.Vm
{
    public class ContactVm
    {   [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="First-Name Cannot be Null")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "First-Name Cannot be Null")]

        public string LastName { get; set; }
        [Required(ErrorMessage = "First-Name Cannot be Null")]

        public int contactNo { get; set; }
    }
}