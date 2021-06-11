using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using Logica.Inventario;

namespace Presentacion
{
    public partial class MttoInventario : Form
    {
        public MttoInventario()
        {
            InitializeComponent();

            InventarioSQL ejecutar = new InventarioSQL();

            try
            {
                List<string> estados = ejecutar.ListarEstadoProductos();
                foreach (string item in estados)
                {
                    cbInsertEstado.Items.Add(item);
                }
            }catch(Exception ex)
            { 
            }

            try
            {
                List<string> categorias = ejecutar.ListarCategoriaProductos();
                foreach (string item in categorias)
                {
                    cbInsertCategoria.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
            }


        }

        private void btnInsertProducto_Click(object sender, EventArgs e)
        {
            InventarioCrud objProducto = new InventarioCrud();
            InventarioSQL ejecutar = new InventarioSQL();


            try
            {

                objProducto.producto_nombre = txtInserNombreProducto.Text;
                objProducto.producto_descripcion = txtInsertDescProducto.Text;
                objProducto.producto_stock =  int.Parse(txtInsertStock.Text);
                objProducto.producto_min_stock = int.Parse(txtInsertMinStock.Text);
                objProducto.producto_precio = decimal.Parse(txtInsertPrecio.Text);
                objProducto.producto_estado = (1+ cbInsertEstado.SelectedIndex );
                objProducto.produccto_categoria = (1 + cbInsertCategoria.SelectedIndex);

                bool resultado = ejecutar.InsertProductoInventario(objProducto);

                if (resultado)
                {
                    MessageBox.Show("Datos guardados exitosamente");
                    txtInserNombreProducto.Text = "";
                    txtInsertDescProducto.Text = "";
                    txtInsertStock.Text = "";
                    txtInsertMinStock.Text = "";
                    txtInsertPrecio.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario");
                }

            }catch(Exception ex)
            {

            }




        }

        private void btnConsultarUpdate_Click(object sender, EventArgs e)
        {
            int idProducto = int.Parse(txtUpdateIDProducto.Text);

            InventarioCrud objProducto = new InventarioCrud();
            InventarioSQL ejecutar = new InventarioSQL();

            cmbEstadoUpdate.Items.Clear();

            try
            {
                DataSet datosProducto = ejecutar.ConsultarProductoPorID(idProducto);

                int registros = datosProducto.Tables["TablaConsultada"].Rows.Count;
                if ( registros == 0)
                {
                    MessageBox.Show("ID no encontrado");
                }
                else
                {
                    txtUpdateIDProducto.Text = datosProducto.Tables["TablaConsultada"].Rows[0]["id_producto"].ToString();
                    txtNombreUpdate.Text = datosProducto.Tables["TablaConsultada"].Rows[0]["producto_nombre"].ToString();
                    txtDescUpdate.Text = datosProducto.Tables["TablaConsultada"].Rows[0]["producto_descripcion"].ToString();
                    txtUpdateMinStock.Text = datosProducto.Tables["TablaConsultada"].Rows[0]["producto_min_stock"].ToString();
                    txtUpdatePrecio.Text = datosProducto.Tables["TablaConsultada"].Rows[0]["producto_precio"].ToString();
                    int idEstado = int.Parse(datosProducto.Tables["TablaConsultada"].Rows[0]["producto_estado"].ToString());

                    try
                    {
                        List<string> estados = ejecutar.ListarEstadoProductos();
                        foreach (string item in estados)
                        {
                            cmbEstadoUpdate.Items.Add(item);
                        }
                        cmbEstadoUpdate.SelectedIndex = (idEstado -1);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }catch(Exception ex)
            {

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InventarioCrud objProducto = new InventarioCrud();
            InventarioSQL ejecutar = new InventarioSQL();

            try
            {
                objProducto.id_Producto = int.Parse(txtUpdateIDProducto.Text);
                objProducto.producto_nombre = txtNombreUpdate.Text;
                objProducto.producto_descripcion = txtDescUpdate.Text;
                objProducto.producto_min_stock = int.Parse( txtUpdateMinStock.Text );
                objProducto.producto_precio = decimal.Parse(txtUpdatePrecio.Text);
                objProducto.producto_estado = (cmbEstadoUpdate.SelectedIndex + 1);

                bool resultado = ejecutar.ActualizarProductoInventario(objProducto);

                if (resultado)
                {
                    MessageBox.Show("Los datos fueron actualizados correctamente");
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

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            InventarioSQL ejecutar = new InventarioSQL();

            try
            {
                DataTable tabla = ejecutar.ListarProductos();

                DGVListProductos.DataSource = tabla;

                if (tabla == null)
                {
                    MessageBox.Show("No hay datos que mostrar");
                }

            }
            catch(Exception ex)
            {

            }
        }
    }
}
