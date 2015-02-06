using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Dialect.Schema;
using NHibernate.Tool.hbm2ddl;
using NHibernate2.Entity;
using NHibernate2.Mapping;

namespace NHibernate2.Config
{
    class SessionConfig
    {
        public ISessionFactory Session;

        public SessionConfig()
        {
            Session = CriateSessionFactory();
        }

        public ISessionFactory CriateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<User>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true,true))
                .BuildSessionFactory();

        }

        public ISession OpenSession()
        {
            return Session?.OpenSession();
        }
    }
}
