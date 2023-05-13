using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class detalleDeuda : Capa_Datos.Conexion
    {
        public int detalleId { get; set; }
        public string estado { get; set; }
        public string fecha { get; set; }
        public int socioId { get; set; }
        public int deudaId { get; set; }
        public string descripcion { get; set; }


        public int crearDeuda(detalleDeuda _deuda, object l)
        {
            string sql = "insert into deudas values ('$Fecha','$Estado', $TipoDeudaId, $SocioId,' $Descripcion')";
            sql = sql.Replace("$Fecha", _deuda.fecha);
            sql = sql.Replace("$Estado", _deuda.estado);
            sql = sql.Replace("$TipoDeudaId", _deuda.deudaId.ToString());
            sql = sql.Replace("$SocioId", _deuda.socioId.ToString());
            sql = sql.Replace("$Descripcion", _deuda.descripcion);
            return ejecutar(sql, l);
        }
        public List<string> cargartiposDeudas()
        {
            return listaDeudas();
        }
        /* -----------     registro de deuda de mensualidad ------- */
        public string[] mensualidad = new string[3];
        public int cargaMasimaMensulidad( object L)
        {
            int cad = 0;
            for (int i = 1; i <= Convert.ToInt32(mensualidad[2]); i++)
            {
                string sql = "insert into deudas values ('$fecha','A',1,$socioId,'$descripcion')";
                sql = sql.Replace("$fecha", mensualidad[0]);
                sql = sql.Replace("$socioId",i.ToString());
                sql = sql.Replace("$descripcion", mensualidad[1]);
                cad = ejecutar(sql, L);
            }
            return cad;
        }
        public string totalSocio(object L) // debe cambiarse a la clase socio
        {
            string sql = "select COUNT(*) from socios";
            return consultar(sql, L).Rows[0][0].ToString();
        }
    }
}
