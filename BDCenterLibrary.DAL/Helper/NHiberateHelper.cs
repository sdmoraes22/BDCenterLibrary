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
                IPersistenceConfigurer configDB = OracleClientConfiguration.Oracle10.ConnectionString(c =>
                    c.Is("DATA SOURCE=CRISTIANO;PERSIST SECURITY INFO=True;USER ID=CRISTIANO;Password=123456"));

                var configMap = Fluently.Configure().Database(configDB).Mappings(m => m.FluentMappings
                        .AddFromAssemblyOf<Livro>().ExportTo(@".\")
                        .AddFromAssemblyOf<Autor>().ExportTo(@".\")
                        .AddFromAssemblyOf<ISBN>().ExportTo(@".\")
                        );

                session = configMap.BuildSessionFactory();
                return session;
            }
        }

        public static ISession AbrirSession()
        {
            return session.OpenSession();
        }


    }
}
