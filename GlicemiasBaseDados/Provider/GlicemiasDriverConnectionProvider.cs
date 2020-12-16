using NHibernate;
using NHibernate.Connection;
using System;
using System.Data;

namespace GlicemiasBaseDados.Provider
{
    public partial class GlicemiasDriverConnectionProvider : ConnectionProvider
    {
        private static readonly IInternalLogger log = LoggerProvider.LoggerFor(typeof(DriverConnectionProvider));

        public override void CloseConnection(IDbConnection conn)
        {
            base.CloseConnection(conn);
            conn.Dispose();
        }

        public override IDbConnection GetConnection()
        {
            log.Debug("Obtaining IDbConnection from Driver");
            IDbConnection conn = Driver.CreateConnection();
            try
            {
                conn.ConnectionString = ConnectionString + "_0";
                conn.Open();
            }
            catch (Exception)
            {
                conn.Dispose();
                throw;
            }

            return conn;
        }

    }
}
