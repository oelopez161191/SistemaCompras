using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class Conexion
    {
        private string mensaje;
        SqlConnection conn;
        SqlTransaction tran;
        SqlDataReader reader;
        SqlCommand cmd;

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public Conexion()
        {
            //Cadena de Conexion Para SQL Server:
            String cadenaconexion = "workstation id=DBCOMPRAS.mssql.somee.com;packet size=4096;user id=oelopez_SQLLogin_2;pwd=grj6fgnt4b;data source=DBCOMPRAS.mssql.somee.com;persist security info=False;initial catalog=DBCOMPRAS";
            conn = new SqlConnection(cadenaconexion);
        }


        public Boolean Conectar()
        {
            Boolean conect = false;

            try
            {
                conn.Open();
            }catch(Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return conect;
        }

        public DataSet ConsultarSQL(String SentenciaSQL)
        {
            try
            {
                conn.Open();
                SqlDataAdapter objRes = new SqlDataAdapter(SentenciaSQL, conn);
                DataSet datos = new DataSet();
                objRes.Fill(datos, "TablaConsultada");
                mensaje = "La consulta de datos fue Exitosa";
                return datos;
            }
            catch (Exception MiExc)
            {
                DataSet datos2 = new DataSet();
                mensaje = "ERROR FATALLITY: " + MiExc.Message;
                return datos2;
            }
            finally
            {
                conn.Close();
            }
        }

        public string ConsultarDatoSQL(String SentenciaSQL)
        {
            string  datos = "";
            try
            {
                conn.Open();
                cmd = new SqlCommand(SentenciaSQL, conn);
                
                    datos = Convert.ToString(cmd.ExecuteScalar());
                
            }
            catch (Exception MiExc)
            {
            }
            finally
            {
                conn.Close();
            }

            return datos;
        }

    public bool EjecutarSQL(String SentenciaSQL)
        {
            try
            {
                conn.Open();
                SqlCommand miComando = new SqlCommand();
                miComando.Connection = conn;
                miComando.CommandText = SentenciaSQL;
                miComando.ExecuteNonQuery();
                mensaje = "Proceso Ejecutado con Exito";
                return true;
            }
            catch (Exception e)
            {
                mensaje = "Tenemos el siguiente Fatality: " + e.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        public DataTable ListarSQL(String SentenciaSQL)
        {
            try
            {
                conn.Open();
                SqlDataAdapter objRes = new SqlDataAdapter(SentenciaSQL, conn);
                DataTable datos = new DataTable();
                objRes.Fill(datos);
                mensaje = "La consulta de datos fue Exitosa";
                return datos;
            }
            catch (Exception MiExc)
            {
                DataTable datos2 = new DataTable();
                mensaje = "ERROR FATALLITY: " + MiExc.Message;
                return datos2;
            }
            finally
            {
                conn.Close();
            }
        }


        public List<string> ListarSQLCombos(String SentenciaSQL)
        {

            List<string> lista = new List<string>(); 
            try 
            {
                conn.Open();
                cmd = new SqlCommand(SentenciaSQL, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(reader["tipo_usuario"].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }


            return lista;
        }

        public List<string> ListarSQLCombosUsuario(String SentenciaSQL)
        {

            List<string> lista = new List<string>();
            try
            {
                conn.Open();
                cmd = new SqlCommand(SentenciaSQL, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(reader["usuario_usuario"].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }


            return lista;
        }

    }
}
