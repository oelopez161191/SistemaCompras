using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.CategoriaEstado;

namespace Presentacion
{
    public partial class MttoCategoriaEstado : Form
    {
        public MttoCategoriaEstado()
        {
            InitializeComponent();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            CategoriaCrud objCat = new CategoriaCrud();
            CategoriaEstadoSQL ejecutar = new CategoriaEstadoSQL();

            try
            {
                objCat.categoria_nombre = txtNCategoria.Text;

                bool resultado = ejecutar.InsertCategoria(objCat);

                if (resultado)
                {
                    MessageBox.Show("Datos guardados exitosamente");
                    txtNCategoria.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario");
                }

            }
            catch(Exception ex)
            {

            }

        }

        private void btnConsultarCategoria_Click(object sender, EventArgs e)
        {
            int id_categoria = int.Parse(txtIDCategoriaUpdate.Text);

            CategoriaEstadoSQL ejecutar = new CategoriaEstadoSQL();
            try
            {
                DataSet datosCategoria = ejecutar.ConsultarCategoriaporID(id_categoria);

                if (datosCategoria.Tables["TablaConsultada"].Rows.Count == 0)
                {
                    MessageBox.Show("ID no encontrado");
                }
                else
                {
                    txtIDCategoriaUpdate.Text = datosCategoria.Tables["TablaConsultada"].Rows[0]["id_categoria"].ToString();
                    txtCategoriaUpdate.Text = datosCategoria.Tables["TablaConsultada"].Rows[0]["categoria_nombre"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btbCategoriaUpdate_Click(object sender, EventArgs e)
        {

            CategoriaCrud objCat = new CategoriaCrud();
            CategoriaEstadoSQL ejecutar = new CategoriaEstadoSQL();

            try
            {
                objCat.id_categoria = int.Parse(txtIDCategoriaUpdate.Text);
                objCat.categoria_nombre = txtCategoriaUpdate.Text;

                bool resultado = ejecutar.ActualizarCategoria(objCat);

                if (resultado)
                {
                    MessageBox.Show("Datos guardados exitosamente");
                    txtIDCategoriaUpdate.Text = "";
                    txtCategoriaUpdate.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario");
                }

            }
            catch (Exception ex)
            {

            }

        }

        private void btnListarCategorias_Click(object sender, EventArgs e)
        {
            CategoriaEstadoSQL ejecutar = new CategoriaEstadoSQL();

            try
            {
                DataTable tabla = ejecutar.ListarCategoria();
                DGVListCategorias.DataSource = tabla;
                DGVListCategorias.Columns[0].HeaderText = "ID";
                DGVListCategorias.Columns[1].HeaderText = "Nombre Categoria";

                if (tabla == null)
                {
                    MessageBox.Show("No hay datos que mostrar");
                }

            }
            catch(Exception ex)
            {

            }

        }

        private void btnInsertEstado_Click(object sender, EventArgs e)
        {
            EstadoCrud objEstado = new EstadoCrud();
            CategoriaEstadoSQL ejecutar = new CategoriaEstadoSQL();

            try
            {
                objEstado.estado_inventario = txtInsertEstado.Text;

                bool resultado = ejecutar.InsertEstado(objEstado);

                if (resultado)
                {
                    MessageBox.Show("Datos guardados exitosamente");
                    txtInsertEstado.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario");
                }

            }
            catch (Exception ex)
            {

            }

        }

        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {
            int id_estado = int.Parse(txtUpdateIDEstado.Text);

            CategoriaEstadoSQL ejecutar = new CategoriaEstadoSQL();
            try
            {
                DataSet datosCategoria = ejecutar.ConsultarEstadoporID(id_estado);

                if (datosCategoria.Tables["TablaConsultada"].Rows.Count == 0)
                {
                    MessageBox.Show("ID no encontrado");
                }
                else
                {
                    txtUpdateIDEstado.Text = datosCategoria.Tables["TablaConsultada"].Rows[0]["id_estado_inventario"].ToString();
                    txtUpdateEstadoNombre.Text = datosCategoria.Tables["TablaConsultada"].Rows[0]["estado_inventario"].ToString();
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btnUpdateEstado_Click(object sender, EventArgs e)
        {
            EstadoCrud objEstado = new EstadoCrud();
            CategoriaEstadoSQL ejecutar = new CategoriaEstadoSQL();

            try
            {
                objEstado.id_estado = int.Parse(txtUpdateIDEstado.Text);
                objEstado.estado_inventario = txtUpdateEstadoNombre.Text;

                bool resultado = ejecutar.ActualizarEstado(objEstado);

                if (resultado)
                {
                    MessageBox.Show("Datos guardados exitosamente");
                    txtIDCategoriaUpdate.Text = "";
                    txtCategoriaUpdate.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario");
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnListEstados_Click(object sender, EventArgs e)
        {
            CategoriaEstadoSQL ejecutar = new CategoriaEstadoSQL();

            try
            {
                DataTable tabla = ejecutar.ListarEstadoInventario();
                DGVEstados.DataSource = tabla;
                DGVEstados.Columns[0].HeaderText = "ID";
                DGVEstados.Columns[1].HeaderText = "Nombre Estado";

                if (tabla == null)
                {
                    MessageBox.Show("No hay datos que mostrar");
                }

            }
            catch (Exception ex)
            {

            }
        }


    }
}
