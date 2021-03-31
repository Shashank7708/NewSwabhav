using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary
{
   public class Employee
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual double salary { get; set; }
        public virtual string position { get; set; }
        public virtual Department Department { get; set; }
    }

    public class Department
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual IList<Employee> Employee { get; set; } = new List<Employee>();

    }

    public class EmployeeMap : ClassMap<Employee>
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

    public class DepartmentMap : ClassMap<Department>
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

    public class Helper11
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString("server=.\\SQLExpress; Database=Transaction; User Id=sa; Password=root"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                .Create(true, false))
                .BuildSessionFactory();


        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }


    }

}
