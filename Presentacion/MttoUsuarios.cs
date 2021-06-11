using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MttoUsuarios : Form
    {
        public MttoUsuarios()
        {
            InitializeComponent();

            cmbTipoUsuario.Items.Clear();

            UsuarioSQL ejectuar = new UsuarioSQL();
            try
            {
                List<string> tipoUsuarios = ejectuar.ConsultarListaTipoUsuario();

                foreach (string item in tipoUsuarios)
                {
                    cmbTipoUsuario.Items.Add(item);
                }

            }
            catch (Exception xx)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioCrudInsert objUser = new UsuarioCrudInsert();
            UsuarioSQL ejectuar = new UsuarioSQL();
            try
            {
                objUser.usuario_usuario = textUsuario.Text;
                objUser.usuario_pass = textContraseña.Text;
                objUser.id_tipo = (cmbTipoUsuario.SelectedIndex +1 );
                objUser.usuario_email = textEmail.Text;
                objUser.usuario_recovery = textSecurity.Text;

                bool resultado = ejectuar.InsertUsuario(objUser);

                if (resultado == true)
                {
                    MessageBox.Show("Datos guardados exitosamente");
                    textUsuario.Text = "";
                    textContraseña.Text = "";
                    textEmail.Text = "";
                    textSecurity.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(objUser.Mensaje);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtidUsuarioae.Text = "";
            txtUsuarioAE.Text = "";
            txtPassAE.Text = "";
            cobID_tipoUsuario.Text = "";
            txtEmailAE.Text = "";
            txtSecurityAE.Text = "";
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            UsuarioSQL sql = new UsuarioSQL();

            try
            {
                DataTable tabla = sql.ListarUsuarios();

                dgvUsuarios.DataSource = tabla;
                dgvUsuarios.Columns[0].HeaderText = "ID";
                dgvUsuarios.Columns[1].HeaderText = "Usuario";
                dgvUsuarios.Columns[2].HeaderText = "Contraseña";
                dgvUsuarios.Columns[3].HeaderText = "Tipo Usuario";
                dgvUsuarios.Columns[4].HeaderText = "E-mail";
                dgvUsuarios.Columns[5].HeaderText = "Palabra Secreta";

                if (tabla == null)
                {
                    MessageBox.Show("No hay datos que mostrar");
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnConsultarAE_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(txtidUsuarioae.Text);

            UsuarioCrudInsert objUsuario = new UsuarioCrudInsert();
            UsuarioSQL ejectuar = new UsuarioSQL();
            cobID_tipoUsuario.Items.Clear();
            try
            {
                DataSet datosUsuario = ejectuar.ConsultarUsuarioID(int.Parse(txtidUsuarioae.Text));

                int numRegistros = datosUsuario.Tables["TablaConsultada"].Rows.Count;

                if (numRegistros == 0)
                {
                    MessageBox.Show("ID no encontrado");
                }
                else
                {
                    txtidUsuarioae.Text = datosUsuario.Tables["TablaConsultada"].Rows[0]["id_usuario"].ToString();
                    txtUsuarioAE.Text = datosUsuario.Tables["TablaConsultada"].Rows[0]["usuario_usuario"].ToString();
                    txtPassAE.Text = datosUsuario.Tables["TablaConsultada"].Rows[0]["usuario_pass"].ToString();
                    int id_tipo = int.Parse(datosUsuario.Tables["TablaConsultada"].Rows[0]["id_tipo"].ToString());
                    txtEmailAE.Text = datosUsuario.Tables["TablaConsultada"].Rows[0]["usuario_email"].ToString();
                    txtSecurityAE.Text = datosUsuario.Tables["TablaConsultada"].Rows[0]["usuario_recovery"].ToString();

                    try
                    {
                        List<string> tipoUsuarios = ejectuar.ConsultarListaTipoUsuario();

                        foreach (string item in tipoUsuarios)
                        {
                            cobID_tipoUsuario.Items.Add(item);
                        }
                        cobID_tipoUsuario.SelectedIndex = (id_tipo - 1 );

                    }
                    catch (Exception xx)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UsuarioSQL sql = new UsuarioSQL();

            try
            {
                bool resultado = sql.EliminarUsuario(int.Parse(txtidUsuarioae.Text));

                if (resultado)
                {
                    MessageBox.Show("Datos de usuario eliminados");
                    txtidUsuarioae.Text = "";
                    txtUsuarioAE.Text = "";
                    txtPassAE.Text = "";
                    cobID_tipoUsuario.Text = "";
                    txtEmailAE.Text = "";
                    txtSecurityAE.Text = "";
                }
                else
                {
                    MessageBox.Show("NO se pudo eliminar usuario");
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btxActualizar_Click(object sender, EventArgs e)
        {
            UsuarioCrudInsert objUser = new UsuarioCrudInsert();
            UsuarioSQL ejectuar = new UsuarioSQL();
            try
            {
                objUser.id_usuario = int.Parse(txtidUsuarioae.Text);
                objUser.usuario_usuario = txtUsuarioAE.Text;
                objUser.usuario_pass = txtPassAE.Text;
                objUser.id_tipo = (1 + cobID_tipoUsuario.SelectedIndex);
                objUser.usuario_email = txtEmailAE.Text;
                objUser.usuario_recovery = txtSecurityAE.Text;

                bool resultado = ejectuar.ActualizarUsuario(objUser);

                if (resultado)
                {
                    MessageBox.Show("Los datos fueron actualizados correctamente");
                    txtidUsuarioae.Text = "";
                    txtUsuarioAE.Text = "";
                    txtPassAE.Text = "";
                    cobID_tipoUsuario.Text = "";
                    txtEmailAE.Text = "";
                    txtSecurityAE.Text = "";

                }
                else
                {
                    MessageBox.Show("Error al actualizar datos");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
