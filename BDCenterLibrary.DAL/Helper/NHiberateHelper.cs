using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using BDCenterLibrary.DAL.Data;
using NHibernate.Tool.hbm2ddl;
using NHibernate;

namespace BDCenterLibrary.DAL.Helper
{
    public class NHiberateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static void CreateSessionFactory()
        {
            _sessionFactory = Fluently.Configure().Database(
            MsSqlConfiguration.MsSql2005
                .ConnectionString(c => c
                .TrustedConnection()
                .Server("localhost")
                .Database("LDTT")))
                .Mappings(m => m.FluentMappings.Add<LivroMap>())
                .Mappings(m => m.FluentMappings.Add<AutorMap>())
                .Mappings(m => m.FluentMappings.Add<ISBNMap>())
            .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
            .BuildSessionFactory();
        }
    }
}
