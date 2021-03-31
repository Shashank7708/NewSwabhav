using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAbdCategory
{
  public  class PostMap:ClassMap<Post>
    {
        public PostMap()
        {
            Id(x => x.Id);

            Map(x => x.Title)
                .Length(5000)
                .Not.Nullable();

            References(x => x.Category)
                .Column("Category");
        }
    }
}
