using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Conexion
    {
        string servidor = "I5ALEX\\SQLEXPRESS";
        string bd = "palmiraSur";

        protected OleDbConnection Conectarse()// se crea la cadena de conexion
        {
            string cadenaConexion = "Provider = SQLOLEDB.1;Data Source =" + servidor + ";Initial Catalog=" + bd + ";Integrated Security=SSPI";
            OleDbConnection con = new OleDbConnection(cadenaConexion);
            con.Open();
            return con;

        }
        protected OleDbTransaction IniciarTransaccion()
        {
            OleDbConnection conex = Conectarse();
            return conex.BeginTransaction();

        }
        protected void dlinea(object tr)
        {
            ((OleDbTransaction)tr).Commit();
        }

        protected void deshacerlinea(object tr)
        {
            ((OleDbTransaction)tr).Rollback();
        }

        //          simple ////////////////////

        protected DataTable consultar(string sql) //Consultas para el llenado de Tabla
        {
            OleDbTransaction tr = IniciarTransaccion();
            DataTable dt = consultar(sql, tr);
            tr.Commit();
            return dt;
        }

        protected DataTable consultar(string sql, object tr) //Consultas
        {
            OleDbDataAdapter ada = new OleDbDataAdapter(sql, ((OleDbTransaction)tr).Connection);
            ada.SelectCommand.Transaction = (OleDbTransaction)tr;
            DataTable dt = new DataTable();
            ada.Fill(dt);//Aqui se queda
            return dt;
        }

        protected int ejecutar(string sql) //insert, delete, update
        {
            OleDbTransaction tr = IniciarTransaccion();
            int i = ejecutar(sql, tr);
            tr.Commit();
            return i;

        }

        protected int ejecutar(string sql, object tr) //insert, delete, update
        {

            OleDbCommand comando = new OleDbCommand(sql, ((OleDbTransaction)tr).Connection);
            comando.Transaction = (OleDbTransaction)tr;
            return comando.ExecuteNonQuery();
        }

        protected int maxPersona()
        {
            string ConnectionString = "Provider = SQLOLEDB.1;Data Source =" + servidor + ";Initial Catalog=\" + bd + \";Integrated Security=SSPI";
            int maxId = 0;
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                string query = "SELECT MAX(id) FROM persona";
                OleDbCommand command = new OleDbCommand(query, connection);
                connection.Open();
                maxId = (int)command.ExecuteScalar();
            }

            return maxId;
        }
        protected List<string> listaDeudas()
        {

            string connectionString = "Provider = SQLOLEDB.1;Data Source =" + servidor + ";Initial Catalog=" + bd + ";Integrated Security=SSPI";
            string tableName = "tipoDeudas";
            string columnName = "nombre";

            List<string> nombres = new List<string>();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand($"SELECT {columnName} FROM {tableName}", connection);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombre = reader.GetString(0);
                        nombres.Add(nombre);
                    }
                }

                connection.Close();
            }
            return nombres;
        }
        protected List<string> listaCategorias()
        {

            string connectionString = "Provider = SQLOLEDB.1;Data Source =" + servidor + ";Initial Catalog=" + bd + ";Integrated Security=SSPI";
            string tableName = "categoriaDeuda";
            string columnName = "nombre";

            List<string> nombres = new List<string>();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand($"SELECT {columnName} FROM {tableName}", connection);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombre = reader.GetString(0);
                        nombres.Add(nombre);
                    }
                }

                connection.Close();
            }
            return nombres;
        }
        //---------------------------------------------------------------
        //By id deudas
        protected int byID(string consulta)
        {
            string connectionString = "Provider = SQLOLEDB.1;Data Source =" + servidor + ";Initial Catalog=" + bd + ";Integrated Security=SSPI";
            int b = 0;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand(consulta, connection);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    b = reader.GetInt32(0);
                }

                reader.Close();
                connection.Close();
            }
            return b;
        }
        protected bool existIdSocio(string sql)
        {
            bool b = false;

            string connectionString = "Provider = SQLOLEDB.1;Data Source =" + servidor + ";Initial Catalog=" + bd + ";Integrated Security=SSPI";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // objeto para ejecutar la consulta
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    // abrir la conexión
                    connection.Open();

                    // ejecutar la consulta y obtener el resultado
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // la persona existe en la tabla
                            b = true;
                        }
                        else
                        {
                            // la persona no existe en la tabla
                            b = false;
                        }
                    }
                }
            }
            return b;
        }
    }
}
