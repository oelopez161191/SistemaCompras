using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se importa libreria system.Data
using System.Data;
using System.Data.SqlClient;

namespace Logica.UsuarioInfo
{
    public class UsuarioInfoSQL:Conexion
    {
        /*
         * Aqui se programan las consultas a SQL
         * 
         */
        public bool InsertUsuarioInfo(UsuarioInfocrudInsert usinf)
        {
            string sql = "";

            if (usinf.usuario_usuario != 0)
            {
                sql = "insert into usuario_info(usuario_nombre, usuario_apellido, usuario_nacimiento, usuario_usuario)" +
                "values('" + usinf.usuario_nombre + "', '" + usinf.usuario_apellido + "', '" + usinf.usuario_nacimiento + "', " + usinf.usuario_usuario + ")";
            }
            else
            {
                sql = "insert into usuario_info(usuario_nombre, usuario_apellido, usuario_nacimiento)" +
                "values('" + usinf.usuario_nombre + "', '" + usinf.usuario_apellido + "', '" + usinf.usuario_nacimiento + "')";

            }
            bool resultado = EjecutarSQL(sql);

            return resultado;
        }

        public bool InsertUsuario(UsuarioCrudInsert us)
        {
            string sql = "insert into usuario(usuario_usuario, usuario_pass, id_tipo, usuario_email, usuario_recovery) " +
                "values ('" + us.usuario_usuario + "','" + us.usuario_pass + "','" + us.id_tipo + "','" + us.usuario_email + "','" + us.usuario_recovery + "')";

            bool resultado = EjecutarSQL(sql);

            return resultado;
        }

        public DataTable ListarUsuariosInfo()
        {
            string sql = "select usinf.id_usuario_info, usinf.usuario_nombre, usinf.usuario_apellido, usinf.usuario_nacimiento, us.usuario_usuario from usuario_info AS usinf inner join usuario as us ON usinf.usuario_usuario = us.id_usuario";
            DataTable tablaRes = ListarSQL(sql);

            return tablaRes;
        }

        public DataTable ListarPersonaSinUsuario()
        {
            string sql = "select usinf.id_usuario_info, usinf.usuario_nombre, usinf.usuario_apellido, usinf.usuario_nacimiento from usuario_info AS usinf where usinf.usuario_usuario is null";
            DataTable tablaRes = ListarSQL(sql);

            return tablaRes;
        }

        public string ConsultarIDUsuario()
        {
            String sql = "SELECT IDENT_CURRENT('usuario ') as cod_usuario";

            string resultado = ConsultarDatoSQL(sql);

            return resultado;
        }

        public DataSet ConsultarUsuarioInfoID(int idUsuarioInfo)
        {
            string sql = "select * from usuario  where id_usuario = " + idUsuarioInfo + " ";

            DataSet resultado = ConsultarSQL(sql);

            return resultado;
        }

        public bool EliminarUsuario(int idUsuarioInfo)
        {
            bool resultado;

            string sql = "delete from usuario_info where id_usuario_info = " + idUsuarioInfo + " ";

            resultado = EjecutarSQL(sql);

            return resultado;
        }

        public bool ActualizarUsuarioInfo(UsuarioInfocrudInsert usuarioinfo)
        {
            string sql = "update usuario_info set " +
                "usuario_nombre = '" + usuarioinfo.usuario_nombre +
                "', usuario_apellido = '" + usuarioinfo.usuario_apellido +
                "', usuario_nacimiento = '" + usuarioinfo.usuario_nacimiento +
                "' where id_usuario_info = " + usuarioinfo.id_usuario_info;

            bool resultado = EjecutarSQL(sql);

            return resultado;
        }

        public List<string> ConsultarListaUsuario()
        {
            string sql = "Select usuario_usuario from usuario order by id_usuario asc";

            List<String> resultado = ListarSQLCombosUsuario(sql);

            return resultado;
        }

        public DataSet ConsultarUsuarioInfoporID(int idUsuarioInfo)
        {
            string sql = "select * from usuario_info  where id_usuario_info = " + idUsuarioInfo + " ";

            DataSet resultado = ConsultarSQL(sql);

            return resultado;
        }
    }
}
