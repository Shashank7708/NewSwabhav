using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WelcomeMVCApp.Models
{
    public class Login
    {   [Required(ErrorMessage ="Name Required")]
        public string name { get;set; }


        [Required(ErrorMessage ="Not a Valid Email Address")]
        [EmailAddress]
        public string email { get; set; }


        [Required(ErrorMessage ="Password Required")]
        [StringLength(12,MinimumLength =8,ErrorMessage ="Password:Min=8 and Max=12")]
        
        public string password { get; set; }

        public int a { get; set; }
        public int counter;
    }
}