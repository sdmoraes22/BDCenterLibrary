using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using BDCenterLibrary.DAL.Model;

namespace BDCenterLibrary.DAL.Helper
{
    public class NHiberateHelper
    {
        private static ISessionFactory session;

        public static ISessionFactory CreateSession()
        {
            if(session != null)
            {
                return session;
            }
            else
            {
                IPersistenceConfigurer configDB = OracleClientConfiguration.Oracle9.ConnectionString(c =>
                    c.Is("Data Source=xe;User Id=CRISTIANO;Password=123456;;"));

                var configMap = Fluently.Configure().Database(configDB).Mappings(m => m.FluentMappings
                        .AddFromAssemblyOf<Livro>()
                        .AddFromAssemblyOf<Autor>()
                        .AddFromAssemblyOf<ISBN>()
                        );

                session = configMap.BuildSessionFactory();
                return session;
            }
        }

        public static ISession AbrirSession()
        {
            CreateSession();
            return session.OpenSession();
        }


    }
}
