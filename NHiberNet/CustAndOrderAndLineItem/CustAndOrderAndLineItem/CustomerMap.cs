using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustAndOrderAndLineItem
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.id);
            Map(x => x.name)
                .Length(50)
                .Not.Nullable();

            Map(x => x.address)
                    .Length(100)
                .Not.Nullable();

            HasMany(x => x.Order)
                .Inverse()
                .Cascade.All();
            Table("tbl_Customer");

        }
    }
}
