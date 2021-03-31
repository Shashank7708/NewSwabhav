using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentAndEmpUsingNhibernate
{
   public class EmployeeMap:ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.id);
            Map(x => x.name)
                .Length(50)
                .Not.Nullable();

            Map(x => x.salary)
                .Length(10)
                .Not.Nullable();

            Map(x => x.position)
                .Length(50)
                .Not.Nullable();

            References(x => x.Department)
                .Column("Department");

            
        }


    }
}
