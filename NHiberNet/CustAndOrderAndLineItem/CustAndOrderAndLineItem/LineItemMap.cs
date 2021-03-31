using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustAndOrderAndLineItem
{
    public class LineItemMap : ClassMap<LineItem>
    {
        public LineItemMap()
        {
            Id(x => x.itemid);
            Map(x => x.Itemname)
                .Length(50)
                .Not.Nullable();
            Map(x => x.PerCost)
                .Length(50)
                .Not.Nullable();
            Map(x => x.quantity)
                .Length(50)
                .Not.Nullable();

            HasManyToMany(x => x.Order)
                .Inverse()
                .Cascade.All();
            Table("tbl_LineItem");
        }


    }
}
