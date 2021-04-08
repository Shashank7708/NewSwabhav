using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoListAsPerUser.Models
{   [Table("Subtask")]
    public class Subtask
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public virtual Task Task { get; set; }
    }
}