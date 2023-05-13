using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public  class Reporte:Capa_Datos.Conexion
    {
        public string[] arrayDatos = new string[3];
        public DataTable pago()
        {
            string sql = "select  s.socioId , tD.nombre,tD.monto,i.fecha from ingresos i \r\ninner join detalleIngresos di\r\non i.ingresoId = di.ingresoId\r\ninner join deudas d\r\non di.deudaId = d.deudaId\r\ninner join tipoDeudas td\r\non td.tipoDeudaId = d.tipoDeudaId\r\ninner join socios s \r\non s.socioId = d.socioId\r\ninner join personas p\r\non p.personaId = s.personaId\r\nwhere i.ingresoId = di.ingresoId and  di.deudaId = d.deudaId and d.tipoDeudaId = $tipoDeuda and i.fecha >= '$Finicial' and i.fecha <= '$Ffinal' ";
            sql = sql.Replace("$tipoDeuda", arrayDatos[0]);
            sql = sql.Replace("$Finicial", arrayDatos[1]);
            sql = sql.Replace("$Ffinal", arrayDatos[2]);

            return consultar(sql);
        }

        public DataTable pagoMixto()
        {
            string sql = "select  s.socioId , tD.nombre,tD.monto,i.fecha from ingresos i \r\ninner join detalleIngresos di\r\non i.ingresoId = di.ingresoId\r\ninner join deudas d\r\non di.deudaId = d.deudaId\r\ninner join tipoDeudas td\r\non td.tipoDeudaId = d.tipoDeudaId\r\ninner join socios s \r\non s.socioId = d.socioId\r\ninner join personas p\r\non p.personaId = s.personaId\r\nwhere i.ingresoId = di.ingresoId and  di.deudaId = d.deudaId and d.tipoDeudaId != 1 and d.tipoDeudaId != 2 and i.fecha >= '$Finicial' and i.fecha <= '$Ffinal' ";

            sql = sql.Replace("$Finicial", arrayDatos[0]);
            sql = sql.Replace("$Ffinal", arrayDatos[1]);
            return consultar(sql);
        }
    }
}
