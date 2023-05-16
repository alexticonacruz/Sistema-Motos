using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class socio:Capa_Datos.Conexion
    {
        public int socioId { get; set; }
        public int personaId { get; set; }
        public string estado { get; set; }

        public int agregar(socio _socio, object L)
        {
            string sql = "insert into socios values ('$1',$2)";
            sql = sql.Replace("$1", _socio.estado);
            sql = sql.Replace("$2", _socio.personaId.ToString());
            return ejecutar(sql, L);
        }
        public bool existeSocio(string cadena)
        {
            string sql = "  select * from socios where socioId = $SocioId";
            sql = sql.Replace("$SocioId", cadena);
            return existIdSocio(sql);
        }
        public DataTable listaSocios()
        {
            string sql = "  select s.socioId, p.nombre, p.apellidoPaterno, p.apellidoMaterno,p.celular,p.domicilio from socios s inner join personas p on s.personaId = p.personaId\r\n";
            return consultar(sql);
        }
        public  DataTable historialSocio(string[] dato)
        {
            string sql = "select s.socioId as INTERNO, p.nombre as NOMBRE, p.apellidoPaterno as APELLIDO, td.nombre as DEUDA, i.descripcion as ESTADO, i.fecha as FIN,d.descripcion as DESCRIPCION,d.fecha as INICIO from \r\ningresos i inner join detalleIngresos di on i.ingresoId = di.ingresoId\r\ninner join deudas d on di.deudaId = d.deudaId\r\ninner join tipoDeudas td on d.tipoDeudaId = td.tipoDeudaId\r\ninner join socios s on d.socioId = s.socioId\r\ninner join personas p on s.personaId = p.personaId\r\nwhere d.estado = 'I' and s.socioId = $socioId and td.tipoDeudaId = $categoria";
            sql = sql.Replace("$socioId", dato[0]);
            sql = sql.Replace("$categoria", dato[1]);
            return consultar(sql);
        }
    }
}
