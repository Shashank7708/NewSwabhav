using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeListUsingMVC.Models
{   [Table("Task")]
    public class Task
    {   [Key]
        public int id { get; set; }
        [AllowHtml]
        public string name { get; set; }
       
        public string date { get; set; }
        public virtual List<Subtask> subtasklist { get; set; } = new List<Subtask>();
        



    }
}