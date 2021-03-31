using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndProduct
{   [Table("Product")]
    class Product
    {   [Key]
        public int pid { get; set; }
        public string productName { get; set; }
        public double productCost { get; set; }
        public virtual Customer customer { get; set; }


    }
}
