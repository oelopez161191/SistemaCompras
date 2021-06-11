
namespace Presentacion
{
    partial class MttoUsuarios
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
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textSecurity = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.lblRecovery = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cobID_tipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btxActualizar = new System.Windows.Forms.Button();
            this.txtSecurityAE = new System.Windows.Forms.TextBox();
            this.txtEmailAE = new System.Windows.Forms.TextBox();
            this.txtPassAE = new System.Windows.Forms.TextBox();
            this.txtUsuarioAE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidUsuarioae = new System.Windows.Forms.TextBox();
            this.lblIDusuarioAE = new System.Windows.Forms.Label();
            this.btnConsultarAE = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.ConsultarLista = new System.Windows.Forms.Button();
            this.idUsuarioSelect = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(749, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbTipoUsuario);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.textSecurity);
            this.tabPage1.Controls.Add(this.textEmail);
            this.tabPage1.Controls.Add(this.textContraseña);
            this.tabPage1.Controls.Add(this.textUsuario);
            this.tabPage1.Controls.Add(this.lblRecovery);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.lbltipo);
            this.tabPage1.Controls.Add(this.passLabel);
            this.tabPage1.Controls.Add(this.UsuarioLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(339, 99);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoUsuario.TabIndex = 12;
            this.cmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUsuario_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(366, 258);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(186, 258);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textSecurity
            // 
            this.textSecurity.Location = new System.Drawing.Point(339, 185);
            this.textSecurity.Name = "textSecurity";
            this.textSecurity.Size = new System.Drawing.Size(100, 20);
            this.textSecurity.TabIndex = 9;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(339, 140);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 8;
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(339, 62);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(100, 20);
            this.textContraseña.TabIndex = 6;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(339, 25);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(100, 20);
            this.textUsuario.TabIndex = 5;
            // 
            // lblRecovery
            // 
            this.lblRecovery.AutoSize = true;
            this.lblRecovery.Location = new System.Drawing.Point(246, 188);
            this.lblRecovery.Name = "lblRecovery";
            this.lblRecovery.Size = new System.Drawing.Size(84, 13);
            this.lblRecovery.TabIndex = 4;
            this.lblRecovery.Text = "Frase Seguridad";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(246, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(243, 102);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(82, 13);
            this.lbltipo.TabIndex = 2;
            this.lbltipo.Text = "Tipo de Usuario";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(243, 65);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(61, 13);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Contraseña";
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Location = new System.Drawing.Point(243, 28);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(43, 13);
            this.UsuarioLabel.TabIndex = 0;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cobID_tipoUsuario);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btxActualizar);
            this.tabPage2.Controls.Add(this.txtSecurityAE);
            this.tabPage2.Controls.Add(this.txtEmailAE);
            this.tabPage2.Controls.Add(this.txtPassAE);
            this.tabPage2.Controls.Add(this.txtUsuarioAE);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtidUsuarioae);
            this.tabPage2.Controls.Add(this.lblIDusuarioAE);
            this.tabPage2.Controls.Add(this.btnConsultarAE);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar / Eliminar Usuari";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cobID_tipoUsuario
            // 
            this.cobID_tipoUsuario.FormattingEnabled = true;
            this.cobID_tipoUsuario.Location = new System.Drawing.Point(322, 149);
            this.cobID_tipoUsuario.Name = "cobID_tipoUsuario";
            this.cobID_tipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cobID_tipoUsuario.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(440, 269);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 39);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btxActualizar
            // 
            this.btxActualizar.Location = new System.Drawing.Point(136, 269);
            this.btxActualizar.Name = "btxActualizar";
            this.btxActualizar.Size = new System.Drawing.Size(133, 39);
            this.btxActualizar.TabIndex = 13;
            this.btxActualizar.Text = "Actualizar";
            this.btxActualizar.UseVisualStyleBackColor = true;
            this.btxActualizar.Click += new System.EventHandler(this.btxActualizar_Click);
            // 
            // txtSecurityAE
            // 
            this.txtSecurityAE.Location = new System.Drawing.Point(322, 211);
            this.txtSecurityAE.Name = "txtSecurityAE";
            this.txtSecurityAE.Size = new System.Drawing.Size(100, 20);
            this.txtSecurityAE.TabIndex = 12;
            // 
            // txtEmailAE
            // 
            this.txtEmailAE.Location = new System.Drawing.Point(322, 181);
            this.txtEmailAE.Name = "txtEmailAE";
            this.txtEmailAE.Size = new System.Drawing.Size(100, 20);
            this.txtEmailAE.TabIndex = 11;
            // 
            // txtPassAE
            // 
            this.txtPassAE.Location = new System.Drawing.Point(322, 113);
            this.txtPassAE.Name = "txtPassAE";
            this.txtPassAE.Size = new System.Drawing.Size(100, 20);
            this.txtPassAE.TabIndex = 9;
            // 
            // txtUsuarioAE
            // 
            this.txtUsuarioAE.Location = new System.Drawing.Point(322, 81);
            this.txtUsuarioAE.Name = "txtUsuarioAE";
            this.txtUsuarioAE.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioAE.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pregunta Seguridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // txtidUsuarioae
            // 
            this.txtidUsuarioae.Location = new System.Drawing.Point(262, 19);
            this.txtidUsuarioae.Name = "txtidUsuarioae";
            this.txtidUsuarioae.Size = new System.Drawing.Size(100, 20);
            this.txtidUsuarioae.TabIndex = 2;
            // 
            // lblIDusuarioAE
            // 
            this.lblIDusuarioAE.AutoSize = true;
            this.lblIDusuarioAE.Location = new System.Drawing.Point(202, 22);
            this.lblIDusuarioAE.Name = "lblIDusuarioAE";
            this.lblIDusuarioAE.Size = new System.Drawing.Size(57, 13);
            this.lblIDusuarioAE.TabIndex = 1;
            this.lblIDusuarioAE.Text = "ID Usuario";
            // 
            // btnConsultarAE
            // 
            this.btnConsultarAE.Location = new System.Drawing.Point(385, 16);
            this.btnConsultarAE.Name = "btnConsultarAE";
            this.btnConsultarAE.Size = new System.Drawing.Size(107, 23);
            this.btnConsultarAE.TabIndex = 0;
            this.btnConsultarAE.Text = "Consultar";
            this.btnConsultarAE.UseVisualStyleBackColor = true;
            this.btnConsultarAE.Click += new System.EventHandler(this.btnConsultarAE_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvUsuarios);
            this.tabPage3.Controls.Add(this.btnSelectAll);
            this.tabPage3.Controls.Add(this.ConsultarLista);
            this.tabPage3.Controls.Add(this.idUsuarioSelect);
            this.tabPage3.Controls.Add(this.lblIdUsuario);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(741, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Usuarios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(37, 63);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(648, 251);
            this.dgvUsuarios.TabIndex = 4;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(349, 12);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Ver Todos";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // ConsultarLista
            // 
            this.ConsultarLista.Location = new System.Drawing.Point(247, 12);
            this.ConsultarLista.Name = "ConsultarLista";
            this.ConsultarLista.Size = new System.Drawing.Size(75, 23);
            this.ConsultarLista.TabIndex = 2;
            this.ConsultarLista.Text = "Consultar";
            this.ConsultarLista.UseVisualStyleBackColor = true;
            // 
            // idUsuarioSelect
            // 
            this.idUsuarioSelect.Location = new System.Drawing.Point(97, 14);
            this.idUsuarioSelect.Name = "idUsuarioSelect";
            this.idUsuarioSelect.Size = new System.Drawing.Size(100, 20);
            this.idUsuarioSelect.TabIndex = 1;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(34, 17);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(57, 13);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "ID Usuario";
            // 
            // MttoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 400);
            this.Controls.Add(this.tabControl1);
            this.Name = "MttoUsuarios";
            this.Text = "MttoUsuarios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textSecurity;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label lblRecovery;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button ConsultarLista;
        private System.Windows.Forms.TextBox idUsuarioSelect;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtidUsuarioae;
        private System.Windows.Forms.Label lblIDusuarioAE;
        private System.Windows.Forms.Button btnConsultarAE;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btxActualizar;
        private System.Windows.Forms.TextBox txtSecurityAE;
        private System.Windows.Forms.TextBox txtEmailAE;
        private System.Windows.Forms.TextBox txtPassAE;
        private System.Windows.Forms.TextBox txtUsuarioAE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobID_tipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
    }
}