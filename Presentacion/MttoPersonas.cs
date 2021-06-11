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
    public partial class MttoPersonas : Form
    {


        //Manejo del usuario 
        public string id_usuario = "";
        public string usuario_usuario = "";
        public string usuario_pass = "";
        public string id_tipo = "";
        public string usuario_email = "";
        public bool Enabled { get; set; }

        public MttoPersonas()
        {
            InitializeComponent();
        }

        //Se gestiona el aceeso al formulario

    }
}
