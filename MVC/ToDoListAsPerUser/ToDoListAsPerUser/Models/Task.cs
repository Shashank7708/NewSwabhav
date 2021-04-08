using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoListAsPerUser.Models
{   [Table("Task")]
    public class Task
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public virtual List<Subtask> subtasklist { get; set; } = new List<Subtask>();
        [Required]
        public virtual User1 user { get; set;}

    }
}