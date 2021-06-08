using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se importa libreria system.Data
using System.Data;

namespace Logica
{
    public class UsuarioSQL:Conexion
    {

       
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

        public bool InsertUsuario (UsuarioCrudInsert us)
        {
            string sql = "insert into usuario(usuario_usuario, usuario_pass, id_tipo, usuario_email, usuario_recovery) " +
                "values ('"+us.usuario_usuario + "','" +us.usuario_email+ "','" + us.id_tipo + "','" + us.usuario_email + "','" + us.usuario_recovery + "')";

            bool resultado = EjecutarSQL(sql);

            return resultado;
        }

    }
}
