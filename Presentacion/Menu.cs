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
    public partial class Menu : Form
    {
        private int childFormNumber = 0;

        //Manejo del usuario 
        public string id_usuario = "";
        public string usuario_usuario ="";
        public string usuario_pass = "";
        public string id_tipo = "";
        public string usuario_email = "";
        public Menu()
        {
            InitializeComponent();
        }

        //Se gestiona el aceeso al formulario

        private void GestionUsuario()
        {
            if (id_tipo == "1" || id_tipo == "2")
            {
                this.viewMenu.Enabled = true;
            }
            else
            {
                this.viewMenu.Enabled = false;
            }

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(id_tipo == "1")
            {
                MttoUsuarioInfo mttoP = new  MttoUsuarioInfo();
                mttoP.MdiParent = this;
                mttoP.Show();
            }
            else
            {
                MessageBox.Show("No tiene acceso a este Mantenimiento", "Sistema de compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id_tipo == "1")
            {
                MttoUsuarios mttoP = new MttoUsuarios();
                mttoP.MdiParent = this;
                mttoP.Show();
            }
            else
            {
                MessageBox.Show("No tiene acceso a este Mantenimiento", "Sistema de compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mttoCategoriaEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MttoCategoriaEstado mtto = new MttoCategoriaEstado();
            mtto.MdiParent = this;
            mtto.Show();
        }

        private void mttoPersonasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MttoInventario mtto = new MttoInventario();
            mtto.MdiParent = this;
            mtto.Show();
        }
    }
}
