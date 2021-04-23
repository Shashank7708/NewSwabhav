﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore.Model
{   [Table("Address")]
  public  class Address
    {   [Key]
        public Guid Id { get; set; }
        
        public string city { get; set; }
        public virtual Contact contact { get; set; } 
    }
}
