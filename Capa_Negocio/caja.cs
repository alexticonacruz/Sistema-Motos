using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class caja : Capa_Datos.Conexion
    {
        public int cajaId { get; set; }
        public int asociacionId { get; set; }
        public decimal dineroActual { get; set; }

        public int agregar(int monto, object l)
        {
            string sql = "update cajas set dineroActual = dineroActual + $Monto where cajaId = 1";
            sql = sql.Replace("$Monto", monto.ToString());
            return ejecutar(sql, l);
        }

        public int descontar(int monto, object l)
        {
            string sql = "update cajas set dineroActual = dineroActual - $Monto where cajaId = 1";
            sql = sql.Replace("$Monto", monto.ToString());
            return ejecutar(sql, l);
        }
    }
}
