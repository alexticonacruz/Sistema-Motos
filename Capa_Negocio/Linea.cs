using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Linea:Capa_Datos.Conexion
    {
        public object linea()
        {
            return IniciarTransaccion();
        }

        public void flinea(object L)
        {
            dlinea(L);
        }

        public void DeshacerLinea(object L)
        {
            deshacerlinea(L);
        }

        public string Llave(object L)
        {
            string sql = "select max(idpersona) from persona";
            return consultar(sql, L).Rows[0][0].ToString();
        }

    }
}
