using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentAndEmpUsingNhibernate
{
   public class DepartmentMap:ClassMap<Department>
    {
        public DepartmentMap()
        {
            Id(x => x.id);
            Map(x => x.name)
                .Length(100)
                .Not.Nullable();

            HasMany(x => x.Employee)
                .Inverse()
                .Cascade.All()
                .KeyColumn("Department");


        }


    }
}
