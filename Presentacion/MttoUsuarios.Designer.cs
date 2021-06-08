
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRecovery = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.textTipoUsuario = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSecurity = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.textSecurity);
            this.tabPage1.Controls.Add(this.textEmail);
            this.tabPage1.Controls.Add(this.textTipoUsuario);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar / Eliminar Usuari";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(741, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LIstar Usuarios";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(243, 65);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(61, 13);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Contraseña";
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(246, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
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
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(339, 25);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(100, 20);
            this.textUsuario.TabIndex = 5;
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(339, 62);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(100, 20);
            this.textContraseña.TabIndex = 6;
            // 
            // textTipoUsuario
            // 
            this.textTipoUsuario.Location = new System.Drawing.Point(339, 99);
            this.textTipoUsuario.Name = "textTipoUsuario";
            this.textTipoUsuario.Size = new System.Drawing.Size(100, 20);
            this.textTipoUsuario.TabIndex = 7;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(339, 140);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 8;
            // 
            // textSecurity
            // 
            this.textSecurity.Location = new System.Drawing.Point(339, 185);
            this.textSecurity.Name = "textSecurity";
            this.textSecurity.Size = new System.Drawing.Size(100, 20);
            this.textSecurity.TabIndex = 9;
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
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(366, 258);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // MttoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MttoUsuarios";
            this.Text = "MttoUsuarios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textSecurity;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTipoUsuario;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label lblRecovery;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
    }
}