using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustAndOrderAndLineItem
{
   public class LineItem
    {
        public virtual int itemid { get; set; }
        public virtual string Itemname { get; set; }
        public virtual double PerCost { get; set; }
        public virtual int quantity { get; set; }

        public virtual IList<Order> Order { get; set; } = new List<Order>();

    }
}
