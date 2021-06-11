using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Logica.UsuarioInfo;

namespace Presentacion
{
    public partial class MttoUsuarioInfo : Form
    {
        public MttoUsuarioInfo()
        {
            InitializeComponent();

            cmbTipoUsuario.Items.Clear();

            cmbUsuarios.Items.Clear();

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

            UsuarioInfoSQL ejecutarUI = new UsuarioInfoSQL();
            try
            {

                List<string> Usuarios = ejecutarUI.ConsultarListaUsuario();

                foreach (string item in Usuarios)
                {
                    cmbUsuarios.Items.Add(item);
                }

            }
            catch (Exception xx)
            {

            }
        }

        private void btnListarPersonas_Click(object sender, EventArgs e)
        {
            UsuarioInfoSQL sql = new UsuarioInfoSQL();

            try
            {
                DataTable tabla = sql.ListarUsuariosInfo();

                dgvPersonas.DataSource = tabla;
                dgvPersonas.Columns[0].HeaderText = "ID";
                dgvPersonas.Columns[1].HeaderText = "Nombre";
                dgvPersonas.Columns[2].HeaderText = "Apellido";
                dgvPersonas.Columns[3].HeaderText = "Fecha Nacimiento";
                dgvPersonas.Columns[4].HeaderText = "Usuario";

                if (tabla == null)
                {
                    MessageBox.Show("No hay datos que mostrar");
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnInsertPersona_Click(object sender, EventArgs e)
        {
            UsuarioCrudInsert objUser = new UsuarioCrudInsert();
            UsuarioSQL ejectuar = new UsuarioSQL();

            UsuarioInfocrudInsert objUInfo = new UsuarioInfocrudInsert();
            UsuarioInfoSQL ejecutarInfo = new UsuarioInfoSQL();
            try
            {
                objUser.usuario_usuario = txtUsuario.Text;
                objUser.usuario_pass = textContrasena.Text;
                objUser.id_tipo = (cmbTipoUsuario.SelectedIndex + 1);
                objUser.usuario_email = txtmail.Text;
                objUser.usuario_recovery = txtFSeguridad.Text;

                bool resultadoUsuario = ejectuar.InsertUsuario(objUser);

                if (resultadoUsuario == true)
                {
                    try
                    {
                        string cod_usuario = ejecutarInfo.ConsultarIDUsuario();

                        objUInfo.usuario_nombre = txtInsertNombre.Text;
                        objUInfo.usuario_apellido = textInsertApellido.Text;
                        objUInfo.usuario_nacimiento = mtbFNacimiento.Text;
                        objUInfo.usuario_usuario = int.Parse(cod_usuario);
                    }
                    catch (Exception ex)
                    {
                        
                    }
                    
                }
                else {
                    objUInfo.usuario_nombre = txtInsertNombre.Text;
                    objUInfo.usuario_apellido = textInsertApellido.Text;
                    objUInfo.usuario_nacimiento = mtbFNacimiento.Text;
                    objUInfo.usuario_usuario = (cmbUsuarios.SelectedIndex + 1);
                }
                {
                    
                }

                bool resultadoUsuarioInfo = ejecutarInfo.InsertUsuarioInfo(objUInfo);

                if (resultadoUsuarioInfo == true) {
                    MessageBox.Show("Datos guardados exitosamente");
                    txtInsertNombre.Text = "";
                    txtContraseña.Text = "";
                    txtEmail.Text = "";
                    txtSeguridad.Text = "";
                    txtInsertNombre.Text = "";
                    txtApellido.Text = "";
                    txtEmail.Text = "";
                    txtNacimiento.Text = "";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioInfoSQL sql = new UsuarioInfoSQL();

            try
            {
                DataTable tabla = sql.ListarPersonaSinUsuario();

                dgvPersonas.DataSource = tabla;
                dgvPersonas.Columns[0].HeaderText = "ID";
                dgvPersonas.Columns[1].HeaderText = "Nombre";
                dgvPersonas.Columns[2].HeaderText = "Apellido";
                dgvPersonas.Columns[3].HeaderText = "Fecha Nacimiento";

                if (tabla == null)
                {
                    MessageBox.Show("No hay datos que mostrar");
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnConsultarPersona_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(txtPersonaID.Text);

            UsuarioCrudInsert objUsuario = new UsuarioCrudInsert();
            UsuarioInfoSQL ejectuar = new UsuarioInfoSQL();

            try
            {
                DataSet datosUsuario = ejectuar.ConsultarUsuarioInfoporID(int.Parse(txtPersonaID.Text));

                int numRegistros = datosUsuario.Tables["TablaConsultada"].Rows.Count;

                if (numRegistros == 0)
                {
                    MessageBox.Show("ID no encontrado");
                }
                else
                {
                    txtPersonaID.Text = datosUsuario.Tables["TablaConsultada"].Rows[0]["id_usuario_info"].ToString();
                    txtActualizarNombre.Text = datosUsuario.Tables["TablaConsultada"].Rows[0]["usuario_nombre"].ToString();
                    txtActualizarApellido.Text = datosUsuario.Tables["TablaConsultada"].Rows[0]["usuario_apellido"].ToString();
                    maskedTextNaximiento.Text = datosUsuario.Tables["TablaConsultada"].Rows[0]["usuario_nacimiento"].ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btxActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActualizarPersona_Click(object sender, EventArgs e)
        {
            UsuarioInfocrudInsert objUser = new UsuarioInfocrudInsert();
            UsuarioInfoSQL ejectuar = new UsuarioInfoSQL();
            try
            {
                objUser.id_usuario_info = int.Parse(txtPersonaID.Text);
                objUser.usuario_nombre = txtActualizarNombre.Text;
                objUser.usuario_apellido = txtActualizarApellido.Text;
                objUser.usuario_nacimiento = maskedTextNaximiento.Text;

                bool resultado = ejectuar.ActualizarUsuarioInfo(objUser);

                if (resultado)
                {
                    MessageBox.Show("Los datos fueron actualizados correctamente");
                    txtPersonaID.Text = "";
                    txtActualizarNombre.Text = "";
                    txtActualizarApellido.Text = "";
                    maskedTextNaximiento.Text = "";

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

        private void txtActualizarFNaci_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
