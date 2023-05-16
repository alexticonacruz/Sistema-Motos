using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Datos.Cache;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos.Cache;

namespace Capa_Datos
{
    public class UserDao : ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.IdUser = reader.GetInt32(0);
                            UserCache.LoginName = reader.GetString(1);
                            UserCache.Password = reader.GetString(2);

                            UserCache.Position = reader.GetString(3);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        public void anyMethod()
        {
            if (UserCache.Position == Positions.Presidente)
            {
                //Lineas o métodos que quieras ejecutar para el cargo recepcionita
            }
            if (UserCache.Position == Positions.VicePresidente)
            {
                //Lineas o métodos que quieras ejecutar para el cargo contador
            }
            if (UserCache.Position == Positions.Tesorera)
            {
                //Lineas o métodos que quieras ejecutar para el cargo contador
            }
            if (UserCache.Position == Positions.secretaria)
            {
                //Lineas o métodos que quieras ejecutar para el cargo contador
            }
        }
    }
}
   
