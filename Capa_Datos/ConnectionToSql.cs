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
        string servidor = "DESKTOP-K3NJ6CR";
        string bd = "palmiraSur";
        public ConnectionToSql()
        {
            connectionString = "Data Source =DESKTOP-K3NJ6CR ;Initial Catalog=palmiraSur;Integrated Security=SSPI";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
