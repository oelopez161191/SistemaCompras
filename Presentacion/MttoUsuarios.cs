using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioCrudInsert objUser = new UsuarioCrudInsert();
            UsuarioSQL ejectuar = new UsuarioSQL();
            try
            {
                objUser.usuario_usuario = textUsuario.Text;
                objUser.usuario_pass = textContraseña.Text;
                objUser.id_tipo = int.Parse(textTipoUsuario.Text);
                objUser.usuario_email = textEmail.Text;
                objUser.usuario_recovery = textSecurity.Text;

                bool resultado = ejectuar.InsertUsuario(objUser);

                if(resultado == true)
                {
                    MessageBox.Show("Datos guardados exitosamente");
                    textUsuario.Text = "";
                    textContraseña.Text = "";
                    textTipoUsuario.Text = "";
                    textEmail.Text = "";
                    textSecurity.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(objUser.Mensaje);
            }
        }
    }
}
