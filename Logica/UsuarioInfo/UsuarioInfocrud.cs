using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.UsuarioInfo
{
    public class UsuarioInfocrudInsert : Conexion
    {
        /*
         * Se declaran las variables a usar
         * son las mismas que la base de datos
         * tabla usuario
         */
        public int id_usuario_info { get; set; }
        public string usuario_nombre { get; set; }
        public string usuario_apellido { get; set; }
        public string usuario_nacimiento { get; set; }
        public int? usuario_usuario { get; set; }
    }

}
