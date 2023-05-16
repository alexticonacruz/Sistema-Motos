using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class ConnectionToSql
    {
        private readonly string connectionString;
        string servidor = "I5ALEX\\SQLEXPRESS";
        string bd = "palmiraSur";
        public ConnectionToSql()
        {
            connectionString = "Data Source =I5ALEX\\SQLEXPRESS ;Initial Catalog=palmiraSur;Integrated Security=SSPI";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
