
namespace Presentacion
{
    partial class MttoCategoriaEstado
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
            this.txtNCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btbCategoriaUpdate = new System.Windows.Forms.Button();
            this.txtCategoriaUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultarCategoria = new System.Windows.Forms.Button();
            this.txtIDCategoriaUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnListarCategorias = new System.Windows.Forms.Button();
            this.DGVListCategorias = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtInsertEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertEstado = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarEstado = new System.Windows.Forms.Button();
            this.txtUpdateIDEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtUpdateEstadoNombre = new System.Windows.Forms.TextBox();
            this.btnUpdateEstado = new System.Windows.Forms.Button();
            this.btnListEstados = new System.Windows.Forms.Button();
            this.DGVEstados = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListCategorias)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txtNCategoria);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAddCategoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(608, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Categoria";
            // 
            // txtNCategoria
            // 
            this.txtNCategoria.Location = new System.Drawing.Point(54, 61);
            this.txtNCategoria.Name = "txtNCategoria";
            this.txtNCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtNCategoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Nueva Categoria";
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Location = new System.Drawing.Point(272, 44);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategoria.TabIndex = 0;
            this.btnAddCategoria.Text = "Agregar";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btbCategoriaUpdate);
            this.tabPage2.Controls.Add(this.txtCategoriaUpdate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnConsultarCategoria);
            this.tabPage2.Controls.Add(this.txtIDCategoriaUpdate);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(608, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar Categoria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btbCategoriaUpdate
            // 
            this.btbCategoriaUpdate.Location = new System.Drawing.Point(167, 162);
            this.btbCategoriaUpdate.Name = "btbCategoriaUpdate";
            this.btbCategoriaUpdate.Size = new System.Drawing.Size(75, 23);
            this.btbCategoriaUpdate.TabIndex = 5;
            this.btbCategoriaUpdate.Text = "Guardar";
            this.btbCategoriaUpdate.UseVisualStyleBackColor = true;
            this.btbCategoriaUpdate.Click += new System.EventHandler(this.btbCategoriaUpdate_Click);
            // 
            // txtCategoriaUpdate
            // 
            this.txtCategoriaUpdate.Location = new System.Drawing.Point(155, 78);
            this.txtCategoriaUpdate.Name = "txtCategoriaUpdate";
            this.txtCategoriaUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtCategoriaUpdate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Categoria";
            // 
            // btnConsultarCategoria
            // 
            this.btnConsultarCategoria.Location = new System.Drawing.Point(284, 19);
            this.btnConsultarCategoria.Name = "btnConsultarCategoria";
            this.btnConsultarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCategoria.TabIndex = 2;
            this.btnConsultarCategoria.Text = "Consultar";
            this.btnConsultarCategoria.UseVisualStyleBackColor = true;
            this.btnConsultarCategoria.Click += new System.EventHandler(this.btnConsultarCategoria_Click);
            // 
            // txtIDCategoriaUpdate
            // 
            this.txtIDCategoriaUpdate.Location = new System.Drawing.Point(155, 21);
            this.txtIDCategoriaUpdate.Name = "txtIDCategoriaUpdate";
            this.txtIDCategoriaUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtIDCategoriaUpdate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Categoria";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnListarCategorias);
            this.tabPage3.Controls.Add(this.DGVListCategorias);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(608, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Categorias";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnListarCategorias
            // 
            this.btnListarCategorias.Location = new System.Drawing.Point(182, 19);
            this.btnListarCategorias.Name = "btnListarCategorias";
            this.btnListarCategorias.Size = new System.Drawing.Size(216, 23);
            this.btnListarCategorias.TabIndex = 1;
            this.btnListarCategorias.Text = "Consultar Todas las Categorias";
            this.btnListarCategorias.UseVisualStyleBackColor = true;
            this.btnListarCategorias.Click += new System.EventHandler(this.btnListarCategorias_Click);
            // 
            // DGVListCategorias
            // 
            this.DGVListCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListCategorias.Location = new System.Drawing.Point(20, 68);
            this.DGVListCategorias.Name = "DGVListCategorias";
            this.DGVListCategorias.Size = new System.Drawing.Size(559, 190);
            this.DGVListCategorias.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtInsertEstado);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.btnInsertEstado);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(608, 338);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Agregar Estado";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtInsertEstado
            // 
            this.txtInsertEstado.Location = new System.Drawing.Point(98, 88);
            this.txtInsertEstado.Name = "txtInsertEstado";
            this.txtInsertEstado.Size = new System.Drawing.Size(100, 20);
            this.txtInsertEstado.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre Nuevo Estado";
            // 
            // btnInsertEstado
            // 
            this.btnInsertEstado.Location = new System.Drawing.Point(289, 67);
            this.btnInsertEstado.Name = "btnInsertEstado";
            this.btnInsertEstado.Size = new System.Drawing.Size(75, 23);
            this.btnInsertEstado.TabIndex = 0;
            this.btnInsertEstado.Text = "Agregar";
            this.btnInsertEstado.UseVisualStyleBackColor = true;
            this.btnInsertEstado.Click += new System.EventHandler(this.btnInsertEstado_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnUpdateEstado);
            this.tabPage5.Controls.Add(this.txtUpdateEstadoNombre);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.btnBuscarEstado);
            this.tabPage5.Controls.Add(this.txtUpdateIDEstado);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(608, 338);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Actualizar Estado";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre Estado";
            // 
            // btnBuscarEstado
            // 
            this.btnBuscarEstado.Location = new System.Drawing.Point(335, 19);
            this.btnBuscarEstado.Name = "btnBuscarEstado";
            this.btnBuscarEstado.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEstado.TabIndex = 2;
            this.btnBuscarEstado.Text = "Buscar";
            this.btnBuscarEstado.UseVisualStyleBackColor = true;
            this.btnBuscarEstado.Click += new System.EventHandler(this.btnBuscarEstado_Click);
            // 
            // txtUpdateIDEstado
            // 
            this.txtUpdateIDEstado.Location = new System.Drawing.Point(148, 27);
            this.txtUpdateIDEstado.Name = "txtUpdateIDEstado";
            this.txtUpdateIDEstado.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateIDEstado.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Estado";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DGVEstados);
            this.tabPage6.Controls.Add(this.btnListEstados);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(608, 338);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Listar Estados";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtUpdateEstadoNombre
            // 
            this.txtUpdateEstadoNombre.Location = new System.Drawing.Point(148, 81);
            this.txtUpdateEstadoNombre.Name = "txtUpdateEstadoNombre";
            this.txtUpdateEstadoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateEstadoNombre.TabIndex = 4;
            // 
            // btnUpdateEstado
            // 
            this.btnUpdateEstado.Location = new System.Drawing.Point(188, 161);
            this.btnUpdateEstado.Name = "btnUpdateEstado";
            this.btnUpdateEstado.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEstado.TabIndex = 5;
            this.btnUpdateEstado.Text = "Actualizar";
            this.btnUpdateEstado.UseVisualStyleBackColor = true;
            this.btnUpdateEstado.Click += new System.EventHandler(this.btnUpdateEstado_Click);
            // 
            // btnListEstados
            // 
            this.btnListEstados.Location = new System.Drawing.Point(147, 19);
            this.btnListEstados.Name = "btnListEstados";
            this.btnListEstados.Size = new System.Drawing.Size(301, 23);
            this.btnListEstados.TabIndex = 0;
            this.btnListEstados.Text = "Mostrar Todos los Estados";
            this.btnListEstados.UseVisualStyleBackColor = true;
            this.btnListEstados.Click += new System.EventHandler(this.btnListEstados_Click);
            // 
            // DGVEstados
            // 
            this.DGVEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEstados.Location = new System.Drawing.Point(22, 56);
            this.DGVEstados.Name = "DGVEstados";
            this.DGVEstados.Size = new System.Drawing.Size(561, 236);
            this.DGVEstados.TabIndex = 1;
            // 
            // MttoCategoriaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MttoCategoriaEstado";
            this.Text = "MttoCategoriaEstado";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListCategorias)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEstados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtNCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.Button btbCategoriaUpdate;
        private System.Windows.Forms.TextBox txtCategoriaUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultarCategoria;
        private System.Windows.Forms.TextBox txtIDCategoriaUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVListCategorias;
        private System.Windows.Forms.Button btnListarCategorias;
        private System.Windows.Forms.TextBox txtInsertEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertEstado;
        private System.Windows.Forms.TextBox txtUpdateIDEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarEstado;
        private System.Windows.Forms.Button btnUpdateEstado;
        private System.Windows.Forms.TextBox txtUpdateEstadoNombre;
        private System.Windows.Forms.DataGridView DGVEstados;
        private System.Windows.Forms.Button btnListEstados;
    }
}