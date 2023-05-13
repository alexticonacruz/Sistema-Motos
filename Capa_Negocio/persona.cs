using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class persona:Capa_Datos.Conexion
    {
        public int personaId { get; set; }
        public int cedulaIdentidad { get; set; }
        public string nombre { get; set; }
        public string nombretwo { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string domicilio { get; set; }
        public int celular { get; set; }


        public int agregarPersona(persona _persona, object L)
        {
            string sql = "insert into personas values('$nombre','$Two','$apellidoPaterno','$apellidoMaterno',$cedulaI,'$domicilio',$celular,1)";
            sql = sql.Replace("$nombre", _persona.nombre);
            sql = sql.Replace("$Two", _persona.nombretwo); // Si nombre2 es nulo, 
            //sql = sql.Replace("$nombreSegundo", _persona.nombre2 ?? "");
            sql = sql.Replace("$apellidoPaterno", _persona.apellidoPaterno);
            sql = sql.Replace("$apellidoMaterno", _persona.apellidoMaterno);
            sql = sql.Replace("$cedulaI", _persona.cedulaIdentidad.ToString());
            sql = sql.Replace("$domicilio", _persona.domicilio);
            sql = sql.Replace("$celular", _persona.celular.ToString());
            return ejecutar(sql, L);
        }

        public string ultimaPersona(object L)
        {
            string sql = "select max(personaId) from personas";
            return consultar(sql, L).Rows[0][0].ToString();
        }
    }
}
