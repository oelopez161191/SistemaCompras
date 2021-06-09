using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se importa libreria system.Data
using System.Data;
using System.Data.SqlClient;

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
                "values ('"+us.usuario_usuario + "','" +us.usuario_pass+ "','" + us.id_tipo + "','" + us.usuario_email + "','" + us.usuario_recovery + "')";

            bool resultado = EjecutarSQL(sql);

            return resultado;
        }


        public DataTable ListarUsuarios()
        {
            string sql = "select us.id_usuario, us.usuario_usuario, us.usuario_pass, TP.tipo_usuario, " +
                "us.usuario_email, us.usuario_recovery  from usuario AS us " +
                "inner join tipo_usuario as TP ON us.id_tipo = TP.id_tipo";

            DataTable tablaRes = ListarSQL(sql);

            return tablaRes;
        }

        public DataSet ConsultarUsuarioID(int idUsuario)
        {
            string sql = "select * from usuario  where id_usuario = " +idUsuario + " ";

            DataSet resultado = ConsultarSQL(sql);

            return resultado;
        }

        public List<string> ConsultarListaTipoUsuario ()
        {
            string sql = "Select tipo_usuario from tipo_usuario order by id_tipo asc";

            List<String> resultado = ListarSQLCombos(sql);

            return resultado;
        }

        public bool EliminarUsuario(int id_usuario)
        {
            bool resultado;

            string sql = "delete from usuario where id_usuario = " + id_usuario + " ";

            resultado = EjecutarSQL(sql);

            return resultado;
        }

        public bool ActualizarUsuario (UsuarioCrudInsert usuario)
        {
            string sql = "update usuario set " +
                "usuario_usuario = '" + usuario.usuario_usuario +
                "', usuario_pass = '" + usuario.usuario_pass +
                "', id_tipo = " + usuario.id_tipo +
                ", usuario_email = '" + usuario.usuario_email +
                "' , usuario_recovery =  '" + usuario.usuario_recovery + "' " +
                " where id_usuario = " + usuario.id_usuario;

            bool resultado = EjecutarSQL(sql);

            return resultado;
        }
    }
}
