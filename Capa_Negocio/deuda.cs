using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class deuda : Capa_Datos.Conexion
    {
        public int deudaId { get; set; }
        public string nombre { get; set; }
        public int monto { get; set; }

        public int byId(string nombre)
        {
            string sql = " select tipoDeudaId from tipoDeudas where nombre = '$nombres'";
            sql = sql.Replace("$nombres", nombre);
            return byID(sql);
        }

        public DataTable consultarDeuda(string interno)
        {
            string sql = "select d.deudaId, p.nombre, p.apellidoPaterno, t.nombre,d.descripcion,d.fecha ,t.monto  from deudas d \r\n  inner join tipoDeudas t ON d.tipoDeudaId = t.tipoDeudaId\r\n  inner join socios s ON s.socioId = d.socioId\r\n  inner join personas p ON s.personaId = p.personaId where d.estado = 'A' and s.socioId = $Interno";

            sql = sql.Replace("$Interno", interno);
            return consultar(sql);
        }
        public DataTable consultarDeuda()
        {
            string sql = "  select d.deudaId, p.nombre, p.apellidoPaterno, t.nombre,d.descripcion,d.fecha ,t.monto  from deudas d \r\n  inner join tipoDeudas t ON d.tipoDeudaId = t.tipoDeudaId\r\n  inner join socios s ON s.socioId = d.socioId\r\n  inner join personas p ON s.personaId = p.personaId where d.estado = 'A' ";
            return consultar(sql);
        }
        public int actualizar(int nombre, object l)
        {
            string sql = "update deudas set estado = 'I' where deudaId = $DeudaId";
            sql = sql.Replace("$DeudaId", nombre.ToString());
            return ejecutar(sql, l);
        }
    }
}
