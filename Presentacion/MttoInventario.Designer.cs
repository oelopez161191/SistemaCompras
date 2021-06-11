
namespace Presentacion
{
    partial class MttoInventario
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
            this.cbInsertCategoria = new System.Windows.Forms.ComboBox();
            this.cbInsertEstado = new System.Windows.Forms.ComboBox();
            this.btnInsertProducto = new System.Windows.Forms.Button();
            this.txtInsertMinStock = new System.Windows.Forms.TextBox();
            this.txtInsertStock = new System.Windows.Forms.TextBox();
            this.txtInsertPrecio = new System.Windows.Forms.TextBox();
            this.txtInsertDescProducto = new System.Windows.Forms.TextBox();
            this.txtInserNombreProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConsultarUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreUpdate = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtUpdateIDProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDescUpdate = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.Label();
            this.txtUpdatePrecio = new System.Windows.Forms.TextBox();
            this.txtUpdateMinStock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEstadoUpdate = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.DGVListProductos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListProductos)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbInsertCategoria);
            this.tabPage1.Controls.Add(this.cbInsertEstado);
            this.tabPage1.Controls.Add(this.btnInsertProducto);
            this.tabPage1.Controls.Add(this.txtInsertMinStock);
            this.tabPage1.Controls.Add(this.txtInsertStock);
            this.tabPage1.Controls.Add(this.txtInsertPrecio);
            this.tabPage1.Controls.Add(this.txtInsertDescProducto);
            this.tabPage1.Controls.Add(this.txtInserNombreProducto);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbInsertCategoria
            // 
            this.cbInsertCategoria.FormattingEnabled = true;
            this.cbInsertCategoria.Location = new System.Drawing.Point(541, 163);
            this.cbInsertCategoria.Name = "cbInsertCategoria";
            this.cbInsertCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbInsertCategoria.TabIndex = 16;
            // 
            // cbInsertEstado
            // 
            this.cbInsertEstado.FormattingEnabled = true;
            this.cbInsertEstado.Location = new System.Drawing.Point(541, 116);
            this.cbInsertEstado.Name = "cbInsertEstado";
            this.cbInsertEstado.Size = new System.Drawing.Size(121, 21);
            this.cbInsertEstado.TabIndex = 15;
            // 
            // btnInsertProducto
            // 
            this.btnInsertProducto.Location = new System.Drawing.Point(334, 305);
            this.btnInsertProducto.Name = "btnInsertProducto";
            this.btnInsertProducto.Size = new System.Drawing.Size(115, 35);
            this.btnInsertProducto.TabIndex = 14;
            this.btnInsertProducto.Text = "Guardar";
            this.btnInsertProducto.UseVisualStyleBackColor = true;
            this.btnInsertProducto.Click += new System.EventHandler(this.btnInsertProducto_Click);
            // 
            // txtInsertMinStock
            // 
            this.txtInsertMinStock.Location = new System.Drawing.Point(541, 69);
            this.txtInsertMinStock.Name = "txtInsertMinStock";
            this.txtInsertMinStock.Size = new System.Drawing.Size(100, 20);
            this.txtInsertMinStock.TabIndex = 11;
            // 
            // txtInsertStock
            // 
            this.txtInsertStock.Location = new System.Drawing.Point(541, 25);
            this.txtInsertStock.Name = "txtInsertStock";
            this.txtInsertStock.Size = new System.Drawing.Size(100, 20);
            this.txtInsertStock.TabIndex = 10;
            // 
            // txtInsertPrecio
            // 
            this.txtInsertPrecio.Location = new System.Drawing.Point(169, 221);
            this.txtInsertPrecio.Name = "txtInsertPrecio";
            this.txtInsertPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtInsertPrecio.TabIndex = 9;
            // 
            // txtInsertDescProducto
            // 
            this.txtInsertDescProducto.Location = new System.Drawing.Point(169, 69);
            this.txtInsertDescProducto.Multiline = true;
            this.txtInsertDescProducto.Name = "txtInsertDescProducto";
            this.txtInsertDescProducto.Size = new System.Drawing.Size(230, 135);
            this.txtInsertDescProducto.TabIndex = 8;
            // 
            // txtInserNombreProducto
            // 
            this.txtInserNombreProducto.Location = new System.Drawing.Point(169, 18);
            this.txtInserNombreProducto.Name = "txtInserNombreProducto";
            this.txtInserNombreProducto.Size = new System.Drawing.Size(230, 20);
            this.txtInserNombreProducto.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock Minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Producto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.cmbEstadoUpdate);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtUpdateMinStock);
            this.tabPage2.Controls.Add(this.txtUpdatePrecio);
            this.tabPage2.Controls.Add(this.Precio);
            this.tabPage2.Controls.Add(this.txtDescUpdate);
            this.tabPage2.Controls.Add(this.btnConsultarUpdate);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtNombreUpdate);
            this.tabPage2.Controls.Add(this.Nombre);
            this.tabPage2.Controls.Add(this.txtUpdateIDProducto);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar Producto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConsultarUpdate
            // 
            this.btnConsultarUpdate.Location = new System.Drawing.Point(276, 7);
            this.btnConsultarUpdate.Name = "btnConsultarUpdate";
            this.btnConsultarUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarUpdate.TabIndex = 5;
            this.btnConsultarUpdate.Text = "Consultar";
            this.btnConsultarUpdate.UseVisualStyleBackColor = true;
            this.btnConsultarUpdate.Click += new System.EventHandler(this.btnConsultarUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Descripción";
            // 
            // txtNombreUpdate
            // 
            this.txtNombreUpdate.Location = new System.Drawing.Point(107, 65);
            this.txtNombreUpdate.Name = "txtNombreUpdate";
            this.txtNombreUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUpdate.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(28, 65);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // txtUpdateIDProducto
            // 
            this.txtUpdateIDProducto.Location = new System.Drawing.Point(107, 15);
            this.txtUpdateIDProducto.Name = "txtUpdateIDProducto";
            this.txtUpdateIDProducto.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateIDProducto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID Producto";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVListProductos);
            this.tabPage3.Controls.Add(this.btnListarProductos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDescUpdate
            // 
            this.txtDescUpdate.Location = new System.Drawing.Point(107, 117);
            this.txtDescUpdate.Multiline = true;
            this.txtDescUpdate.Name = "txtDescUpdate";
            this.txtDescUpdate.Size = new System.Drawing.Size(253, 129);
            this.txtDescUpdate.TabIndex = 6;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(425, 65);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 7;
            this.Precio.Text = "Precio";
            // 
            // txtUpdatePrecio
            // 
            this.txtUpdatePrecio.Location = new System.Drawing.Point(493, 65);
            this.txtUpdatePrecio.Name = "txtUpdatePrecio";
            this.txtUpdatePrecio.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePrecio.TabIndex = 8;
            // 
            // txtUpdateMinStock
            // 
            this.txtUpdateMinStock.Location = new System.Drawing.Point(505, 104);
            this.txtUpdateMinStock.Name = "txtUpdateMinStock";
            this.txtUpdateMinStock.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateMinStock.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Stock Minimo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(428, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Estado";
            // 
            // cmbEstadoUpdate
            // 
            this.cmbEstadoUpdate.FormattingEnabled = true;
            this.cmbEstadoUpdate.Location = new System.Drawing.Point(493, 144);
            this.cmbEstadoUpdate.Name = "cmbEstadoUpdate";
            this.cmbEstadoUpdate.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoUpdate.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(340, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 55);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Location = new System.Drawing.Point(245, 16);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(219, 35);
            this.btnListarProductos.TabIndex = 0;
            this.btnListarProductos.Text = "Listar todos los Productos";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // DGVListProductos
            // 
            this.DGVListProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListProductos.Location = new System.Drawing.Point(3, 57);
            this.DGVListProductos.Name = "DGVListProductos";
            this.DGVListProductos.Size = new System.Drawing.Size(762, 340);
            this.DGVListProductos.TabIndex = 1;
            // 
            // MttoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MttoInventario";
            this.Text = "MttoInventario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbInsertCategoria;
        private System.Windows.Forms.ComboBox cbInsertEstado;
        private System.Windows.Forms.Button btnInsertProducto;
        private System.Windows.Forms.TextBox txtInsertMinStock;
        private System.Windows.Forms.TextBox txtInsertStock;
        private System.Windows.Forms.TextBox txtInsertPrecio;
        private System.Windows.Forms.TextBox txtInsertDescProducto;
        private System.Windows.Forms.TextBox txtInserNombreProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConsultarUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreUpdate;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtUpdateIDProducto;
        private System.Windows.Forms.TextBox txtDescUpdate;
        private System.Windows.Forms.ComboBox cmbEstadoUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateMinStock;
        private System.Windows.Forms.TextBox txtUpdatePrecio;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnListarProductos;
        private System.Windows.Forms.DataGridView DGVListProductos;
    }
}