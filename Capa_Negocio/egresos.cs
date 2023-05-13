using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class egresos : Capa_Datos.Conexion
    {
        public string[] listaEgreso = new string[3];
        public DataTable egreso(string[] dato)
        {
            string sql = "select * from egresos where fecha >= '$fechaInicio' and fecha <= '$fechaFin'";
            sql = sql.Replace("$fechaInicio", dato[0]);
            sql = sql.Replace("$fechaFin", dato[1]);
            return consultar(sql);
        }   
        public int agregar(object l)
        {
            string sql = "insert into egresos values ($monto, '$detalle', '$fecha',1, 1)";
            sql = sql.Replace("$monto", listaEgreso[0]);
            sql = sql.Replace("$detalle", listaEgreso[1]);
            sql = sql.Replace("$fecha", listaEgreso[2]);
            return ejecutar(sql, l);
        }

        public DataTable inicio()
        {
            string sql = "select * from egresos";
            return consultar(sql);
        }

    }
}
