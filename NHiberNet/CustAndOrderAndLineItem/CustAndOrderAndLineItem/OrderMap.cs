using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustAndOrderAndLineItem
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Id(x => x.Oid);

            References(x => x.Customer)
                ;
            HasManyToMany(x => x.LineItem)
               .Cascade.All();
            Table("Tbl_Order");
        }
    }
}
