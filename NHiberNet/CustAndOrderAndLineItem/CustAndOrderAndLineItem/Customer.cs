using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustAndOrderAndLineItem
{
   public class Customer
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual string address { get; set; }
        public virtual IList<Order> Order { get; set; } = new List<Order>();
    }
}
