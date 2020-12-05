using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlicemiasBaseDados.Uteis
{
    public static class Db
    {

        private static string SERVER = "localhost";
        private static string PORT = "5432";
        private static string ID = "postgres";
        private static string PASSWORD = "postgres123";
        private static string DATABASE = "glicemias";


        public static void GetConnectionDb()
        {
            string connectionString = "Server=" + SERVER + ";Port=5432;UserID=" + ID + ";password=" + PASSWORD + ";Database=" + DATABASE + ";";

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao conectar com banco de dados");
            }
        }

    }
}
