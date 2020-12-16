using GlicemiasBaseDados.Provider;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GlicemiasBaseDados.Uteis
{
    public static class Db
    {

        public static ISessionFactory SessionFactory { get; set; }
        public static string IpBd = "localhost";
        public static string PortaBd = "5432";
        public static string NomeBd = "glicemias";
        public static Configuration Configuration;

        private const string FileConfig = "ConfigHibernate.cfg.xml";

        public static void GetConnectionDb()
        {
            try
            {
                SessionFactory?.Dispose();
                SessionFactory = null;


                Configuration = new Configuration().Configure(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileConfig));

                Configuration.DataBaseIntegration(b =>
                {
                    b.Driver<NpgsqlDriver>();
                    b.Dialect<PostgreSQLDialect>();
                    b.ConnectionString = "Server=" + IpBd + ";Port=" + PortaBd + ";User Id=postgres;Password=postgres123;Database=" + NomeBd + "ConvertInfinityDateTime=true;" +
                    "ApplicationName=" + System.Environment.MachineName;
                    b.ConnectionProvider<GlicemiasDriverConnectionProvider>();
                }
                );

                var mapper = new ModelMapper();
                mapper.AddMappings(Assembly.GetExecutingAssembly().GetExportedTypes());
                var domainMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
                Configuration.AddMapping(domainMapping);

                var intercept = new NotificaBindingInterceptor();
                SessionFactory = Configuration.SetInterceptor(intercept).BuildSessionFactory();
                intercept.SessionFactory = SessionFactory;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
