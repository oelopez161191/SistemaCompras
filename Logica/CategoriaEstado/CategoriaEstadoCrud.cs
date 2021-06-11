using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.CategoriaEstado
{
    public class CategoriaEstadoCrud : Conexion
    {
    }


    public class CategoriaCrud : Conexion
    {
        public int id_categoria { get; set; }

        public string categoria_nombre { get; set; }
    }


    public class EstadoCrud : Conexion
    {
        public int id_estado { get; set; }

        public string estado_inventario { get; set; }

    }


}
