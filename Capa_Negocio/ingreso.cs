using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class ingreso : Capa_Datos.Conexion
    {
        public int ingresoId { get; set; }
        public int monto { get; set; }
        public string descripcion { get; set; }
        public int cajaId { get; set; }
        public int usuarioId { get; set; }
        public string fecha { get; set; }

        public int agregar(ingreso _ingreso, object L)
        {
            string sql = "insert into ingresos values ($Monto,'$Descripcion',$CajaId,$UsuarioId,'$Fecha')";
            sql = sql.Replace("$Monto", _ingreso.monto.ToString());
            sql = sql.Replace("$Descripcion", _ingreso.descripcion);
            sql = sql.Replace("$CajaId", _ingreso.cajaId.ToString());
            sql = sql.Replace("$UsuarioId", _ingreso.usuarioId.ToString());
            sql = sql.Replace("$Fecha", _ingreso.fecha.ToString());
            return ejecutar(sql, L);
        }
        public string ultimaIngreso(object L)
        {
            string sql = "select max(ingresoId) from ingresos";
            return consultar(sql, L).Rows[0][0].ToString();
        }
    }
}
