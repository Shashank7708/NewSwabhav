using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCandEntityFramework.ViewModels
{
    public class ContactVm
    {       [Required]
            public string fname { get; set; }
            
            public string lname { get; set; }
            public int phoneno { get; set; }
            public string address { get; set; }
        }
    }
