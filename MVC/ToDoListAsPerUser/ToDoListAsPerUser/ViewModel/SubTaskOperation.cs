using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoListAsPerUser.ViewModel
{
    public class SubTaskOperation
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
        public string parentname { get; set; }
    }
}