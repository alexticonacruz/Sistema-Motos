using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class detalleIngreso : Capa_Datos.Conexion
    {
        public int detalleIngresoId { get; set; }
        public int ingresoId { get; set; }
        public int deudaId { get; set; }


        public int agregar(detalleIngreso _detalleIngreso, object l)
        {
            string sql = "insert into detalleIngresos values ($IngresoId,$DeudaId)";
            sql = sql.Replace("$IngresoId", _detalleIngreso.ingresoId.ToString());
            sql = sql.Replace("$DeudaId", _detalleIngreso.deudaId.ToString());
            return ejecutar(sql, l);
        }
    }
}
