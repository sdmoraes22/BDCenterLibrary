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

        public static void CreateSessionFactory()
        {
            _sessionFactory = Fluently.Configure().Database(
            MsSqlConfiguration.MsSql2008
                .ConnectionString(c => c
                .TrustedConnection()
                .Server("localhost")
                .Database("Biblioteca")))
                .Mappings(m => m.FluentMappings.Add<LivroMap>())
                .Mappings(m => m.FluentMappings.Add<AutorMap>())
                .Mappings(m => m.FluentMappings.Add<ISBNMap>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
                .BuildSessionFactory();
        }

    }
}
