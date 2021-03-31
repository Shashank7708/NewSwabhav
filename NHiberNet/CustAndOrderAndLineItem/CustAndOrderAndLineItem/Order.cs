using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustAndOrderAndLineItem
{
  public  class Order
    {
        public virtual int Oid { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual IList<LineItem> LineItem { get; set; } = new List<LineItem>();
    }
}
