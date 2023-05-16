using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class categoriaDeuda:Capa_Datos.Conexion
    {
        public int categoriaIdDeuda { get; set; }
        public string nombre { get; set; }
        public int crear(categoriaDeuda _catDeuda, object L)
        {
            string sql = "insert into categoriaDeuda values ($nombre)";
            sql = sql.Replace("$nombre",_catDeuda.nombre);

            return ejecutar(sql, L);
        }
        public  List<string> listCategoria()
        {
            return listaCategorias();
        }
       
    }
}
