using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Inventario
{
    public class InventarioCrud : Conexion
    {

        public int id_Producto { get; set; }

        public string producto_nombre { get; set; }

        public string producto_descripcion { get; set; }

        public int producto_stock { get; set; }

        public int producto_min_stock { get; set; }

        public decimal producto_precio { get; set; }

        public string producto_imagen { get; set; }
        
        public int producto_estado { get; set; }

        public int produccto_categoria { get; set; }


    }
}
