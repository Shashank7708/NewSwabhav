using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndProduct
{   [Table("Customer")]
    class Customer
    {   [Key]
        public int customerid { get; set; }
        public string customerName { get; set; }
        public string address { get; set; }
        
        public virtual List<Product> CustomerProduct { get; }

        public Customer()
        {
            CustomerProduct = new List<Product>();
        }


    }
}
