using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DTOEmployee.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string designation { get; set; }
        public int salary { get; set; }
    }
}