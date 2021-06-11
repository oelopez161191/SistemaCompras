using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioCrudInsert : Conexion
    {
        /*
         * Se declaran las variables a usar
         * son las mismas que la base de datos
         * tabla usuario
         */
        public int id_usuario { get; set; }

        public string usuario_usuario { get; set; }

        public string usuario_pass { get; set; }

        public int id_tipo { get; set; }

        public string usuario_email { get; set; }

        public string usuario_recovery { get; set; }
    }

    public class PersonaCrudInsert :Conexion
    {
        /*
         * Se declaran las variables a usar
         * son las mismas que la base de datos
         * tabla usuario_info
         */
        public int id_usuario_info { get; set; }

        public string usuario_nombre { get; set; }

        public string usuario_apellido { get; set; }

        public DateTime usuario_nacimiento { get; set; }

        public int usuario_id { get; set; }
    }

    public class Tipo_Usuario : Conexion
    {
        public int id_tipo { get; set; }

        public string tipo_usuario { get; set; }
    }

}
