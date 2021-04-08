using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoListAsPerUser.Models
{   [Table("User1")]
    public class User1
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public virtual List<Task> tasklist { get; set; } = new List<Task>();


    }
}