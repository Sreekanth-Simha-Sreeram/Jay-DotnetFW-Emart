using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

using NHibernate;

namespace EMart.DataLayer
{
    public class NHibernateHelper
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
            .Database(MySQLConfiguration.Standard
           .ConnectionString(@"Data Source=192.168.1.165;Initial Catalog=emartnew1;User ID=root;Password=root;persist security info=True"))
          .Mappings(m => m.FluentMappings.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly()))
           .BuildSessionFactory();

        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}

