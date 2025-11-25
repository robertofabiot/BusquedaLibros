using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaLibros.GUI
{
    public partial class Form1 : Form
    {
        private AutorDAO autorDAO = new AutorDAO();
        private LibroDAO libroDAO = new LibroDAO();

        private string nombreAutorSeleccionado = null;
        private string nombreLibroSeleccionado = null;
        public Form1()
        {
            InitializeComponent();
            tabControl.SelectedTab = tbGestion;
            btnTabGestion.Enabled = false;
        }

        #region Métodos auxiliares
        private void CargarDatosPrueba()
        {
            autorDAO.AgregarAutor("Gabriel García Márquez");
            autorDAO.AgregarAutor("J.K. Rowling");
            // Refrescamos para que aparezcan
        }

        private void ActualizarVistas()
        {
            // 1. Refrescar Grilla de Autores
            dgvAutores.DataSource = null;
            dgvAutores.DataSource = autorDAO.Autores;

            //// 2. Refrescar Grilla de Libros
            //dgvLibros.DataSource = null;
            //dgvLibros.DataSource = libroDAO.Libros;

            //// 3. Refrescar el ComboBox de Autores (Para crear libros)
            //cmbLibroAutor.Items.Clear();
            //foreach (var autor in autorDAO.Autores)
            //{
            //    cmbLibroAutor.Items.Add(autor.Nombre);
            //}
        }

        private void LimpiarCamposAutor()
        {
            tbNombreAutor.Clear();
            nombreAutorSeleccionado = null;
        }

        //private void LimpiarCamposLibro()
        //{
        //    txtLibroNombre.Clear();
        //    txtLibroDesc.Clear();
        //    cmbLibroAutor.SelectedIndex = -1;
        //    dtpLibroFecha.Value = DateTime.Now;
        //    nombreLibroSeleccionado = null;
        //}
        #endregion

        private void btnTabGestion_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbGestion;
        }

        private void btnTabBusqueda_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbBusqueda;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Métodos de autores
        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNombreAutor.Text))
            {
                autorDAO.AgregarAutor(tbNombreAutor.Text);
                ActualizarVistas();
                LimpiarCamposAutor();
                MessageBox.Show("Autor agregado.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEliminarAutor_Click(object sender, EventArgs e)
        {
            if (nombreAutorSeleccionado != null)
            {
                autorDAO.EliminarAutor(nombreAutorSeleccionado);
                ActualizarVistas();
                LimpiarCamposAutor();
            }
            else
            {
                MessageBox.Show("Seleccione un autor de la lista primero.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditarAutor_Click(object sender, EventArgs e)
        {
            if (nombreAutorSeleccionado != null && !string.IsNullOrEmpty(tbNombreAutor.Text))
            {
                autorDAO.UpdateAutor(nombreAutorSeleccionado, tbNombreAutor.Text);
                ActualizarVistas();
                LimpiarCamposAutor();
            }
            else
            {
                MessageBox.Show("Seleccione un autor de la lista primero.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenemos el objeto de la fila seleccionada
                Autor autor = (Autor)dgvAutores.Rows[e.RowIndex].DataBoundItem;

                // Llenamos los campos
                tbNombreAutor.Text = autor.Nombre;

                // Guardamos el nombre original para poder buscarlo al editar/borrar
                nombreAutorSeleccionado = autor.Nombre;
            }
        }
        #endregion
    }
}
