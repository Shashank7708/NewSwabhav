using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService2
{
    [DataContract]
    [Table("Person")]
    public class Person
    {
        [Key]
        [Required]
        [DataMember]
        public int id { get; set; }
        [Required]
        [DataMember]
        public string name { get; set; }

        [Required]
        [DataMember]
        public string address { get; set; }


    }
}