using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoListAsPerUser.ViewModel
{
    public class Login1
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}