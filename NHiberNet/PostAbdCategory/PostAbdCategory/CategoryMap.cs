using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAbdCategory
{
   public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id);

            Map(x => x.Name)
                .Length(50)
                .Not.Nullable();

            HasMany(x => x.Post)
                .Inverse()
                .Cascade.All()
                .KeyColumn("Category");
        }
    }
}
