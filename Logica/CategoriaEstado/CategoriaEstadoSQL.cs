using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.CategoriaEstado
{
    public class CategoriaEstadoSQL : CategoriaEstadoCrud
    {

        public bool InsertCategoria(CategoriaCrud cat)
        {
            string sql = "insert into categoria(categoria_nombre) " +
                "values ('" + cat.categoria_nombre + "')";

            bool resultado = EjecutarSQL(sql);

            return resultado;
        }


        public bool InsertEstado(EstadoCrud estado)
        {
            string sql = "insert into estado_inventario(estado_inventario) " +
                "values ('" + estado.estado_inventario + "')";

            bool resultado = EjecutarSQL(sql);

            return resultado;
        }

        public DataSet ConsultarCategoriaporID(int id_categoria)
        {
            string sql = "select * from categoria  where id_categoria = " + id_categoria + " ";
            DataSet resultado = ConsultarSQL(sql);

            return resultado;
        }


        public DataSet ConsultarEstadoporID(int id_estado)
        {
            string sql = "select * from estado_inventario  where id_estado_inventario = " + id_estado + " ";
            DataSet resultado = ConsultarSQL(sql);

            return resultado;
        }

        public bool ActualizarCategoria(CategoriaCrud cat)
        {
            string sql = "update categoria set categoria_nombre = '" + cat.categoria_nombre
                + "' where id_categoria = " + cat.id_categoria + " ";

            bool res = EjecutarSQL(sql);

            return res;
        }


        public bool ActualizarEstado(EstadoCrud estado)
        {
            string sql = "update estado_inventario set estado_inventario = '" + estado.estado_inventario
                + "' where id_estado_inventario = " + estado.id_estado + " ";

            bool res = EjecutarSQL(sql);

            return res;
        }

        public DataTable ListarCategoria()
        {
            string sql = "select * from categoria;";

            DataTable tablaRes = ListarSQL(sql);

            return tablaRes;
        }


        public DataTable ListarEstadoInventario()
        {
            string sql = "select * from estado_inventario;";

            DataTable tablaRes = ListarSQL(sql);

            return tablaRes;
        }


    }
}
