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

namespace Quaternary
{
    public class Category
    {

        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual IList<Post> Post { get; set; } = new List<Post>();
    }

    public class Helper10
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
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString("server=.\\SQLExpress; Database=sabhav; User Id=sa; Password=root"))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                .Create(true, true))
                .BuildSessionFactory();
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

    }

    public class Post
    {
        public virtual int id { get; set; }
        public virtual string title { get; set; }
        public virtual Category Category { get; set; }

    }


    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Id(x => x.id);
            Map(x => x.title)
                .Length(5000)
                .Not.Nullable();

            References(x => x.Category)
                .Column("Category");
        }
    }


    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.id);
            Map(x => x.name)
                .Length(50)
                .Not.Nullable();

            HasMany(x => x.Post)
                .Inverse()
                .Cascade.All()
                .KeyColumn("Category");

        }
    }
}