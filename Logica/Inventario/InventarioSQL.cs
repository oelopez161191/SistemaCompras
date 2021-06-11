using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Inventario
{
    public class InventarioSQL : InventarioCrud
    {

        public bool InsertProductoInventario(InventarioCrud inv)
        {
            string sql = "insert into inventario (producto_nombre, producto_descripcion, producto_stock, producto_min_stock, producto_precio, producto_estado, producto_categoria)"
                + " values ('"+inv.producto_nombre + "', '" + inv.producto_descripcion + "', '" + inv.producto_stock + "', '"+ inv.producto_min_stock + "', ' "+ inv.producto_precio + "', " + inv.producto_estado + ", " + inv.produccto_categoria +")";
            
            bool resultado = EjecutarSQL(sql);

            return resultado;
        }

        public DataSet ConsultarProductoPorID(int id_producto)
        {
            string sql = "SELECT * FROM inventario WHERE id_producto = " + id_producto+ ";";
            DataSet resultado = ConsultarSQL(sql);

            return resultado;
        }


        public bool ActualizarProductoInventario(InventarioCrud pro)
        {
            string sql = " UPDATE inventario SET producto_nombre = '" + pro.producto_nombre +
                "', producto_descripcion = '" + pro.producto_descripcion +
                "', producto_min_stock =  " + pro.producto_min_stock +
                ", producto_precio = " + pro.producto_precio +
                ", producto_estado =" + pro.producto_estado +
                " WHERE id_producto = " + pro.id_Producto + " ;";

            bool res = EjecutarSQL(sql);

            return res;
        }


        public DataTable ListarProductos()
        {
            string sql = "select INV.id_producto, INV.producto_nombre, INV.producto_descripcion, INV.producto_stock, " +
                "INV.producto_min_stock, INV.producto_precio, EI.estado_inventario, CAT.categoria_nombre from inventario as INV  " +
                "inner join categoria as CAT ON INV.producto_categoria = CAT.id_categoria " +
                "inner join estado_inventario as EI on INV.producto_estado = EI.id_estado_inventario";

            DataTable tablaRes = ListarSQL(sql);

            return tablaRes;
        }

        public List<string> ListarEstadoProductos()
        {
            List<string> resultado = null;
            string sql = "select estado_inventario from estado_inventario order by id_estado_inventario asc";
            
            try
            {
                 resultado = ListarSQLCombos(sql, "estado_inventario");
            }catch(Exception ex)
            {

            }
            return resultado;
        }


        public List<string> ListarCategoriaProductos()
        {
            string sql = "SELECT categoria_nombre FROM categoria order by id_categoria asc";
            string campTabla = "categoria_nombre";
            List<string> resultado = ListarSQLCombos(sql, campTabla);

            return resultado;
        }

    }
}
