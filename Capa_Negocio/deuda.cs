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
        public int categoriaId { get; set; }

        public int byId(string nombre)
        {
            string sql = " select tipoDeudaId from tipoDeudas where nombre = '$nombres'";
            sql = sql.Replace("$nombres", nombre);
            return byID(sql);
        }

        public DataTable consultarDeuda(string interno)
        {
            string sql = "select d.deudaId,s.socioId, p.nombre, p.apellidoPaterno, t.nombre,d.descripcion,d.fecha ,t.monto  from deudas d \r\n  inner join tipoDeudas t ON d.tipoDeudaId = t.tipoDeudaId\r\n  inner join socios s ON s.socioId = d.socioId\r\n  inner join personas p ON s.personaId = p.personaId where d.estado = 'A' and s.socioId = $Interno";

            sql = sql.Replace("$Interno", interno);
            return consultor(consultar(sql));
            //return consultar(sql);
        }
        public DataTable consultarDeuda()
        {
            string sql = "  select d.deudaId,s.socioId, p.nombre, p.apellidoPaterno, t.nombre,d.descripcion,d.fecha ,t.monto  from deudas d \r\n  inner join tipoDeudas t ON d.tipoDeudaId = t.tipoDeudaId\r\n  inner join socios s ON s.socioId = d.socioId\r\n  inner join personas p ON s.personaId = p.personaId where d.estado = 'A' ";
            //return consultar(sql);
            return consultor(consultar(sql));
        }
        public int actualizar(int nombre, object l)
        {
            string sql = "update deudas set estado = 'I' where deudaId = $DeudaId";
            sql = sql.Replace("$DeudaId", nombre.ToString());
            return ejecutar(sql, l);
        }

        /* -----    Diseño de tabla final implementacion ---------*/

        public DataTable consultor(DataTable _tabla)
        {
            if (vacioDT(_tabla))
            {
                return finalTable(_tabla);
            }
            return _tabla;
            
        }

        public bool vacioDT(DataTable _tabla)
        {
            if (_tabla.Rows.Count > 0) { return true; }
            else
            {
                return false;
            }
        }
        public DataTable finalTable(DataTable _tabla)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("DeudaId");
            tabla.Columns.Add("Interno");
            tabla.Columns.Add("NombreCompleto");
            tabla.Columns.Add("Deuda");
            tabla.Columns.Add("Descripcion");
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Monto");

            foreach (DataRow fila in _tabla.Rows)
            {
                string valor0 = fila["deudaId"].ToString();
                string valor01 = fila["socioId"].ToString();
                string valor1 = fila["nombre"].ToString();
                string valor2 = fila["apellidoPaterno"].ToString();
                string valorConcatenado = $"{valor1} {valor2}";
                string valor3 = fila["nombre1"].ToString();
                string valor4 = fila["descripcion"].ToString();
                string valor5 = fila["fecha"].ToString();
                string valor6 = fila["monto"].ToString();
                tabla.Rows.Add(valor0,valor01, valorConcatenado, valor3, valor4, valor5, valor6);
            }

            return tabla;

        }
        /* Crear una deuda nueva  a su respenctiva Categoria*/
        public int crearDeuda(deuda _deuda, object L)
        {
            string sql = "insert into tipoDeudas values ('$nombre',$monto,$categoriaId)";
            sql = sql.Replace("$nombre", _deuda.nombre);
            sql = sql.Replace("$monto", _deuda.monto.ToString());
            sql = sql.Replace("$categoriaId", _deuda.categoriaId.ToString());
            return ejecutar(sql, L);
        }
        public  string buscarNameCategory(object L,string dato)
        {
            string sql = "select categoriaId from categoriaDeuda where nombre = '$catId'";
            sql = sql.Replace("$catId", dato);
            return consultar(sql, L).Rows[0][0].ToString();
        }
    }
}
