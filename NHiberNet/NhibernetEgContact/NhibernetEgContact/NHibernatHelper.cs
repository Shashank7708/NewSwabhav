using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MySql.Data.MySqlClient;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernetEgContact
{
    class NHibernatHelper
    {
        private static  ISessionFactory _sessionFactory;
        
        
        public static ISessionFactory SessionFactory
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
                     .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(@"server=.\SQLExpress; Database=NHibernetContact; User Id=sa; Password=root;")
                    .ShowSql()).
                    Mappings(m => m.FluentMappings.AddFromAssemblyOf<Contact>())
                    .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, false))
                    .BuildSessionFactory();
        }

        /* Create session */
      public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
