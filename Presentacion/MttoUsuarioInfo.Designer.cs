
namespace Presentacion
{
    partial class MttoUsuarioInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mtbFNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.txtUsuarioInf = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txtFSeguridad = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.txtSeguridad = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.textInsertApellido = new System.Windows.Forms.TextBox();
            this.txtNacimiento = new System.Windows.Forms.Label();
            this.btnInsertPersona = new System.Windows.Forms.Button();
            this.txtInsertNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtActualizarApellido = new System.Windows.Forms.TextBox();
            this.txtActualizarNombre = new System.Windows.Forms.TextBox();
            this.btnEliminarPersona = new System.Windows.Forms.Button();
            this.btnActualizarPersona = new System.Windows.Forms.Button();
            this.btnConsultarPersona = new System.Windows.Forms.Button();
            this.txtPersonaID = new System.Windows.Forms.TextBox();
            this.txtIdPersona = new System.Windows.Forms.Label();
            this.txtActualizarFNac = new System.Windows.Forms.Label();
            this.lblboxapellido = new System.Windows.Forms.Label();
            this.lblbox2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnListarSinUsuario = new System.Windows.Forms.Button();
            this.btnListarPersonas = new System.Windows.Forms.Button();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.maskedTextNaximiento = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mtbFNacimiento);
            this.tabPage1.Controls.Add(this.cmbUsuarios);
            this.tabPage1.Controls.Add(this.txtUsuarioInf);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.cmbTipoUsuario);
            this.tabPage1.Controls.Add(this.txtFSeguridad);
            this.tabPage1.Controls.Add(this.txtmail);
            this.tabPage1.Controls.Add(this.textContrasena);
            this.tabPage1.Controls.Add(this.txtSeguridad);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtTipo);
            this.tabPage1.Controls.Add(this.txtContraseña);
            this.tabPage1.Controls.Add(this.Usuario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtLimpiar);
            this.tabPage1.Controls.Add(this.txtUsuario);
            this.tabPage1.Controls.Add(this.textInsertApellido);
            this.tabPage1.Controls.Add(this.txtNacimiento);
            this.tabPage1.Controls.Add(this.btnInsertPersona);
            this.tabPage1.Controls.Add(this.txtInsertNombre);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar Informacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mtbFNacimiento
            // 
            this.mtbFNacimiento.Location = new System.Drawing.Point(156, 158);
            this.mtbFNacimiento.Mask = "00/00/0000";
            this.mtbFNacimiento.Name = "mtbFNacimiento";
            this.mtbFNacimiento.Size = new System.Drawing.Size(144, 20);
            this.mtbFNacimiento.TabIndex = 21;
            this.mtbFNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(156, 215);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(144, 21);
            this.cmbUsuarios.TabIndex = 20;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbxUsuarios_SelectedIndexChanged);
            // 
            // txtUsuarioInf
            // 
            this.txtUsuarioInf.AutoSize = true;
            this.txtUsuarioInf.Location = new System.Drawing.Point(43, 218);
            this.txtUsuarioInf.Name = "txtUsuarioInf";
            this.txtUsuarioInf.Size = new System.Drawing.Size(43, 13);
            this.txtUsuarioInf.TabIndex = 19;
            this.txtUsuarioInf.Text = "Usuario";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(376, 281);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(484, 136);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(136, 21);
            this.cmbTipoUsuario.TabIndex = 16;
            // 
            // txtFSeguridad
            // 
            this.txtFSeguridad.Location = new System.Drawing.Point(484, 203);
            this.txtFSeguridad.Name = "txtFSeguridad";
            this.txtFSeguridad.Size = new System.Drawing.Size(136, 20);
            this.txtFSeguridad.TabIndex = 15;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(484, 167);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(136, 20);
            this.txtmail.TabIndex = 14;
            // 
            // textContrasena
            // 
            this.textContrasena.Location = new System.Drawing.Point(484, 105);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.Size = new System.Drawing.Size(136, 20);
            this.textContrasena.TabIndex = 13;
            // 
            // txtSeguridad
            // 
            this.txtSeguridad.AutoSize = true;
            this.txtSeguridad.Location = new System.Drawing.Point(386, 206);
            this.txtSeguridad.Name = "txtSeguridad";
            this.txtSeguridad.Size = new System.Drawing.Size(84, 13);
            this.txtSeguridad.TabIndex = 12;
            this.txtSeguridad.Text = "Frase Seguridad";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(386, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(32, 13);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Text = "Email";
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.Location = new System.Drawing.Point(386, 136);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(65, 13);
            this.txtTipo.TabIndex = 10;
            this.txtTipo.Text = "Tipo usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.Location = new System.Drawing.Point(386, 105);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(61, 13);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.Text = "Contraseña";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(386, 74);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 8;
            this.Usuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.Location = new System.Drawing.Point(0, 0);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(75, 23);
            this.txtLimpiar.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(484, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(136, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // textInsertApellido
            // 
            this.textInsertApellido.Location = new System.Drawing.Point(156, 113);
            this.textInsertApellido.Name = "textInsertApellido";
            this.textInsertApellido.Size = new System.Drawing.Size(144, 20);
            this.textInsertApellido.TabIndex = 5;
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.AutoSize = true;
            this.txtNacimiento.Location = new System.Drawing.Point(42, 158);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(108, 13);
            this.txtNacimiento.TabIndex = 4;
            this.txtNacimiento.Text = "Fecha de Nacimiento";
            // 
            // btnInsertPersona
            // 
            this.btnInsertPersona.Location = new System.Drawing.Point(156, 281);
            this.btnInsertPersona.Name = "btnInsertPersona";
            this.btnInsertPersona.Size = new System.Drawing.Size(145, 23);
            this.btnInsertPersona.TabIndex = 3;
            this.btnInsertPersona.Text = "Guardar";
            this.btnInsertPersona.UseVisualStyleBackColor = true;
            this.btnInsertPersona.Click += new System.EventHandler(this.btnInsertPersona_Click);
            // 
            // txtInsertNombre
            // 
            this.txtInsertNombre.Location = new System.Drawing.Point(156, 71);
            this.txtInsertNombre.Name = "txtInsertNombre";
            this.txtInsertNombre.Size = new System.Drawing.Size(144, 20);
            this.txtInsertNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.Location = new System.Drawing.Point(42, 116);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(44, 13);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(42, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 65);
            this.label3.TabIndex = 18;
            this.label3.Text = "Si no posee usuario, deje el campo vacio.\r\n\r\n\r\n\r\n\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.maskedTextNaximiento);
            this.tabPage2.Controls.Add(this.txtActualizarApellido);
            this.tabPage2.Controls.Add(this.txtActualizarNombre);
            this.tabPage2.Controls.Add(this.btnEliminarPersona);
            this.tabPage2.Controls.Add(this.btnActualizarPersona);
            this.tabPage2.Controls.Add(this.btnConsultarPersona);
            this.tabPage2.Controls.Add(this.txtPersonaID);
            this.tabPage2.Controls.Add(this.txtIdPersona);
            this.tabPage2.Controls.Add(this.txtActualizarFNac);
            this.tabPage2.Controls.Add(this.lblboxapellido);
            this.tabPage2.Controls.Add(this.lblbox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar / Eliminar Persona";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtActualizarApellido
            // 
            this.txtActualizarApellido.Location = new System.Drawing.Point(307, 166);
            this.txtActualizarApellido.Name = "txtActualizarApellido";
            this.txtActualizarApellido.Size = new System.Drawing.Size(123, 20);
            this.txtActualizarApellido.TabIndex = 9;
            // 
            // txtActualizarNombre
            // 
            this.txtActualizarNombre.Location = new System.Drawing.Point(307, 118);
            this.txtActualizarNombre.Name = "txtActualizarNombre";
            this.txtActualizarNombre.Size = new System.Drawing.Size(123, 20);
            this.txtActualizarNombre.TabIndex = 8;
            // 
            // btnEliminarPersona
            // 
            this.btnEliminarPersona.Location = new System.Drawing.Point(395, 272);
            this.btnEliminarPersona.Name = "btnEliminarPersona";
            this.btnEliminarPersona.Size = new System.Drawing.Size(135, 36);
            this.btnEliminarPersona.TabIndex = 7;
            this.btnEliminarPersona.Text = "Eliminar";
            this.btnEliminarPersona.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPersona
            // 
            this.btnActualizarPersona.Location = new System.Drawing.Point(151, 272);
            this.btnActualizarPersona.Name = "btnActualizarPersona";
            this.btnActualizarPersona.Size = new System.Drawing.Size(122, 36);
            this.btnActualizarPersona.TabIndex = 6;
            this.btnActualizarPersona.Text = "Actualizar";
            this.btnActualizarPersona.UseVisualStyleBackColor = true;
            this.btnActualizarPersona.Click += new System.EventHandler(this.btnActualizarPersona_Click);
            // 
            // btnConsultarPersona
            // 
            this.btnConsultarPersona.Location = new System.Drawing.Point(408, 34);
            this.btnConsultarPersona.Name = "btnConsultarPersona";
            this.btnConsultarPersona.Size = new System.Drawing.Size(108, 23);
            this.btnConsultarPersona.TabIndex = 5;
            this.btnConsultarPersona.Text = "Consultar";
            this.btnConsultarPersona.UseVisualStyleBackColor = true;
            this.btnConsultarPersona.Click += new System.EventHandler(this.btnConsultarPersona_Click);
            // 
            // txtPersonaID
            // 
            this.txtPersonaID.Location = new System.Drawing.Point(265, 36);
            this.txtPersonaID.Name = "txtPersonaID";
            this.txtPersonaID.Size = new System.Drawing.Size(126, 20);
            this.txtPersonaID.TabIndex = 4;
            // 
            // txtIdPersona
            // 
            this.txtIdPersona.AutoSize = true;
            this.txtIdPersona.Location = new System.Drawing.Point(199, 39);
            this.txtIdPersona.Name = "txtIdPersona";
            this.txtIdPersona.Size = new System.Drawing.Size(60, 13);
            this.txtIdPersona.TabIndex = 3;
            this.txtIdPersona.Text = "ID Persona";
            // 
            // txtActualizarFNac
            // 
            this.txtActualizarFNac.AutoSize = true;
            this.txtActualizarFNac.Location = new System.Drawing.Point(199, 211);
            this.txtActualizarFNac.Name = "txtActualizarFNac";
            this.txtActualizarFNac.Size = new System.Drawing.Size(93, 13);
            this.txtActualizarFNac.TabIndex = 2;
            this.txtActualizarFNac.Text = "Fecha Nacimiento";
            // 
            // lblboxapellido
            // 
            this.lblboxapellido.AutoSize = true;
            this.lblboxapellido.Location = new System.Drawing.Point(199, 166);
            this.lblboxapellido.Name = "lblboxapellido";
            this.lblboxapellido.Size = new System.Drawing.Size(44, 13);
            this.lblboxapellido.TabIndex = 1;
            this.lblboxapellido.Text = "Apellido";
            // 
            // lblbox2
            // 
            this.lblbox2.AutoSize = true;
            this.lblbox2.Location = new System.Drawing.Point(199, 118);
            this.lblbox2.Name = "lblbox2";
            this.lblbox2.Size = new System.Drawing.Size(44, 13);
            this.lblbox2.TabIndex = 0;
            this.lblbox2.Text = "Nombre";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnListarSinUsuario);
            this.tabPage3.Controls.Add(this.btnListarPersonas);
            this.tabPage3.Controls.Add(this.dgvPersonas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(709, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Personas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnListarSinUsuario
            // 
            this.btnListarSinUsuario.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnListarSinUsuario.Location = new System.Drawing.Point(360, 23);
            this.btnListarSinUsuario.Name = "btnListarSinUsuario";
            this.btnListarSinUsuario.Size = new System.Drawing.Size(202, 23);
            this.btnListarSinUsuario.TabIndex = 2;
            this.btnListarSinUsuario.Text = "Consultar Persona sin Usuario";
            this.btnListarSinUsuario.UseVisualStyleBackColor = false;
            this.btnListarSinUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListarPersonas
            // 
            this.btnListarPersonas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListarPersonas.Location = new System.Drawing.Point(104, 23);
            this.btnListarPersonas.Name = "btnListarPersonas";
            this.btnListarPersonas.Size = new System.Drawing.Size(205, 23);
            this.btnListarPersonas.TabIndex = 1;
            this.btnListarPersonas.Text = "Consultar Persona con Usuario";
            this.btnListarPersonas.UseVisualStyleBackColor = false;
            this.btnListarPersonas.Click += new System.EventHandler(this.btnListarPersonas_Click);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(45, 64);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(613, 273);
            this.dgvPersonas.TabIndex = 0;
            // 
            // maskedTextNaximiento
            // 
            this.maskedTextNaximiento.Location = new System.Drawing.Point(307, 208);
            this.maskedTextNaximiento.Mask = "00/00/0000";
            this.maskedTextNaximiento.Name = "maskedTextNaximiento";
            this.maskedTextNaximiento.Size = new System.Drawing.Size(123, 20);
            this.maskedTextNaximiento.TabIndex = 11;
            this.maskedTextNaximiento.ValidatingType = typeof(System.DateTime);
            // 
            // MttoUsuarioInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 409);
            this.Controls.Add(this.tabControl1);
            this.Name = "MttoUsuarioInfo";
            this.Text = "MttoUsuarioInfo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnInsertPersona;
        private System.Windows.Forms.TextBox txtInsertNombre;
        private System.Windows.Forms.Label txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnListarPersonas;
        private System.Windows.Forms.TextBox textInsertApellido;
        private System.Windows.Forms.Label txtNacimiento;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button txtLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox textContrasena;
        private System.Windows.Forms.Label txtSeguridad;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtTipo;
        private System.Windows.Forms.Label txtContraseña;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.TextBox txtFSeguridad;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label txtUsuarioInf;
        private System.Windows.Forms.Label txtActualizarFNac;
        private System.Windows.Forms.Label lblboxapellido;
        private System.Windows.Forms.Label lblbox2;
        private System.Windows.Forms.Button btnConsultarPersona;
        private System.Windows.Forms.TextBox txtPersonaID;
        private System.Windows.Forms.Label txtIdPersona;
        private System.Windows.Forms.MaskedTextBox mtbFNacimiento;
        private System.Windows.Forms.TextBox txtActualizarApellido;
        private System.Windows.Forms.TextBox txtActualizarNombre;
        private System.Windows.Forms.Button btnEliminarPersona;
        private System.Windows.Forms.Button btnActualizarPersona;
        private System.Windows.Forms.Button btnListarSinUsuario;
        private System.Windows.Forms.MaskedTextBox maskedTextNaximiento;
    }
}