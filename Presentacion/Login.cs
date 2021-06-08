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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Logica.UsuarioSQL objUser = new Logica.UsuarioSQL();
            try
            {
                string usuario = txtUsuario.Text;
                string pass = txtContraseña.Text;

                DataSet datosUsuario = objUser.Login(usuario, pass);
                int cantidadregistros = datosUsuario.Tables["TablaConsultada"].Rows.Count;
                
                if (cantidadregistros == 0)
                {
                    MessageBox.Show("USuario / Contraseña invalido", "Sistema de compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Menu frm = new Menu();

                    frm.id_usuario = datosUsuario.Tables["TablaConsultada"].Rows[0]["id_usuario"].ToString();
                    frm.usuario_usuario = datosUsuario.Tables["TablaConsultada"].Rows[0]["usuario_usuario"].ToString();
                    frm.id_tipo = datosUsuario.Tables["TablaConsultada"].Rows[0]["id_tipo"].ToString();

                    frm.Show();
                    this.Hide();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Fatality!: " + ex.Message + " " + objUser.Mensaje);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

