﻿using System;
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
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public Conexion()
        {
            //Cadena de Conexion Para SQL Server:
            String cadenaconexion = "";
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
    }
}
