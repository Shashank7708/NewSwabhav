using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustAndOrderAndLineItem
{
   
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

