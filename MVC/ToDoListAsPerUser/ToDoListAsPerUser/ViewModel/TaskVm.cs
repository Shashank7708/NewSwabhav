﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ToDoListAsPerUser.Models;

namespace ToDoListAsPerUser.ViewModel
{
    public class TaskVm
    {

   
        [Required]
        public string name { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public  int user { get; set; }

    }
}