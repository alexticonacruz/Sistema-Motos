using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class moto:Capa_Datos.Conexion
    {
        public string[] listaMoto = new string[4];

        public int agregar(object l)
        {
            string sql = "insert into motos values ('$Marca','$Modelo',$SocioId,'$Placa')";
            sql = sql.Replace("$Marca", listaMoto[0]);
            sql = sql.Replace("$Modelo", listaMoto[1]);
            sql = sql.Replace("$SocioId", listaMoto[2]);
            sql = sql.Replace("$Placa", listaMoto[3]);
            return ejecutar(sql, l);
        }
    }
}
