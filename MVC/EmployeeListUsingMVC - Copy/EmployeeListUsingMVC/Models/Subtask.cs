using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeListUsingMVC.Models
{   [Table("Subtask")]
    public class Subtask
    {   [Key]
        public int id { get; set; }
        
        public string name { get; set; }
        public string date { get; set; }
        public string status { get; set; }
        public virtual Task Task { get; set; }


    }
}