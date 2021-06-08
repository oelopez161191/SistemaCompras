using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se importa libreria system.Data
using System.Data;

namespace Logica
{
    public class Usuario:Conexion
    {

        /*
         * Se declaran las variables a usar
         * son las mismas que la base de datos
         * 
         */
        public int id_usuario { get; set; }
     
        public string usuario_usuario { get; set; }

        public string usuario_pass { get; set; }

        public int id_tipo { get; set; }

        public string usuario_email { get; set; }

        public string usuario_recovery { get; set; }


        /*
         * Aqui se programan las consultas a SQL
         * 
         */

        public DataSet Login (string usuario, string password)
        {
            string sql = "select * from usuario where usuario_usuario = '"
                + usuario + "' and usuario_pass = '" + password + "'";
            
            DataSet resultado = ConsultarSQL(sql);

            return resultado;
        }

    }
}
