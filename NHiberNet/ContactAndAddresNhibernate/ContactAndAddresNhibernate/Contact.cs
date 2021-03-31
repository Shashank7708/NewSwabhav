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

namespace ContactAndAddresNhibernate
{
   public class Contact
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int PhoneNo { get; set; }
        public virtual IList<Address> Address { get; set; } = new List<Address>();

    }

    public class Address
    {
        public virtual int Aid { get; set; }
        public virtual string City { get; set; }
        public virtual int pincode { get; set; }
        public virtual Contact Contact { get; set; }
    }

    public class AddressMap:ClassMap<Address>
    {
        public AddressMap()
        {
            Id(x => x.Aid);
            Map(x => x.City)
                .Length(50)
                .Not.Nullable();
            Map(x => x.pincode)
                .Length(20)
                .Not.Nullable();
            References(x => x.Contact);
        }
    }

    public class ContactMap:ClassMap<Contact>
    {
        public ContactMap()
        {
            Id(x => x.Id);
            Map(x=>x.FirstName)
                .Length(50)
                .Not.Nullable();
            Map(x=>x.LastName)
                .Length(50)
                .Not.Nullable();
            Map(x=>x.PhoneNo)
                .Length(50)
                .Not.Nullable();
            HasMany(x => x.Address)
                .Inverse()
                .Cascade.All();
        }
    }

    public class Helper16
    {
        static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    initializeSession();
                return _sessionFactory;
            }
        }

        private static void initializeSession()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString("server=.\\SQLExpress; Database=DeptAndEmp; User Id=sa; Password=root"))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Program>())
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
