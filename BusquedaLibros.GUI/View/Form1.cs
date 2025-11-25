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
            tabControl.SelectedTab = tabGestion;
            btnTabGestion.Enabled = false;
            CargarDatosPrueba();
            ActualizarVistas();
            dgvLibros.ForeColor = Color.Black;
            dgvAutores.ForeColor = Color.Black;
        }

        #region Métodos auxiliares
        private void CargarDatosPrueba()
        {
            // --- 1. Gabriel García Márquez ---
            autorDAO.AgregarAutor("Gabriel García Márquez");
            // Buscamos el objeto autor que acabamos de crear
            Autor gabriel = autorDAO.Autores.Find(a => a.Nombre == "Gabriel García Márquez");

            if (gabriel != null)
            {
                libroDAO.AgregarLibro("Cien años de soledad", gabriel, new DateTime(1967, 5, 30), "Obra maestra del realismo mágico.");
                libroDAO.AgregarLibro("El amor en los tiempos del cólera", gabriel, new DateTime(1985, 1, 1), "Historia de amor.");
            }

            // --- 2. J.K. Rowling ---
            autorDAO.AgregarAutor("J.K. Rowling");
            Autor rowling = autorDAO.Autores.Find(a => a.Nombre == "J.K. Rowling");

            if (rowling != null)
            {
                libroDAO.AgregarLibro("Harry Potter y la piedra filosofal", rowling, new DateTime(1997, 6, 26), "Magia y aventuras.");
            }

            // --- 3. George Orwell ---
            autorDAO.AgregarAutor("George Orwell");
            Autor orwell = autorDAO.Autores.Find(a => a.Nombre == "George Orwell");

            if (orwell != null)
            {
                libroDAO.AgregarLibro("1984", orwell, new DateTime(1949, 6, 8), "Novela distópica sobre el control social.");
                libroDAO.AgregarLibro("Rebelión en la granja", orwell, new DateTime(1945, 8, 17), "Sátira política.");
            }

            // --- 4. Isaac Asimov ---
            autorDAO.AgregarAutor("Isaac Asimov");
            Autor asimov = autorDAO.Autores.Find(a => a.Nombre == "Isaac Asimov");

            if (asimov != null)
            {
                libroDAO.AgregarLibro("Yo, Robot", asimov, new DateTime(1950, 12, 2), "Colección de relatos sobre robótica.");
            }
        }

        private void ActualizarVistas()
        {
            // 1. Refrescar Grilla de Autores
            dgvAutores.DataSource = null;
            dgvAutores.DataSource = autorDAO.Autores;

            // 2. Refrescar Grilla de Libros
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libroDAO.Libros;
            

            // 3.Refrescar el ComboBox de Autores(Para crear libros)
            cbAutores.Items.Clear();
            foreach (var autor in autorDAO.Autores)
            {
                cbAutores.Items.Add(autor.Nombre);
            }
        }

        private void LimpiarCamposAutor()
        {
            tbNombreAutor.Clear();
            nombreAutorSeleccionado = null;
        }

        private void LimpiarCamposLibro()
        {
            tbNombreLibro.Clear();
            tbDescripcion.Clear();
            cbAutores.SelectedIndex = -1;
            dtpLibroFecha.Value = DateTime.Now;
            nombreLibroSeleccionado = null;
        }
        private void ImprimirLibro(Libro libro)
        {
            tbResultados.AppendText($"Título: {libro.Nombre}\n");
            tbResultados.AppendText($"Autor: {(libro.Autor != null ? libro.Autor.Nombre : "Desconocido")}\n");
            tbResultados.AppendText($"Fecha: {libro.FechaPublicacion.ToShortDateString()}\n");
            tbResultados.AppendText($"Descripción: {libro.Descripcion}\n");
        }
        #endregion

        #region Métodos para botones de tabs
        private void btnTabGestion_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabGestion;
            btnTabGestion.Enabled = false;
            btnTabBusqueda.Enabled = true;
        }

        private void btnTabBusqueda_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabBusqueda;
            btnTabGestion.Enabled = true;
            btnTabBusqueda.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

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
            bool tieneLibros = false;
            foreach (Libro libro in libroDAO.GetListaLibros())
            {
                if (libro.Autor != null && libro.Autor.Nombre == nombreAutorSeleccionado)
                {
                    tieneLibros = true;
                    break;
                }
            }
            if (tieneLibros)
            {
                MessageBox.Show("No se puede eliminar el autor porque tiene libros asociados.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        #region Métodos de libros
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            // Validar que haya un autor seleccionado
            if (cbAutores.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un autor.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Buscar el objeto Autor real basado en el nombre del ComboBox
            string nombreAutor = cbAutores.SelectedItem.ToString();
            Autor autorObj = autorDAO.Autores.Find(a => a.Nombre == nombreAutor);

            if (autorObj != null)
            {
                libroDAO.AgregarLibro(
                    tbNombreLibro.Text,
                    autorObj,
                    dtpLibroFecha.Value,
                    tbDescripcion.Text
                );
                ActualizarVistas();
                LimpiarCamposLibro();
                MessageBox.Show("Libro agregado.");
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (nombreLibroSeleccionado != null)
            {
                libroDAO.EliminarLibro(nombreLibroSeleccionado);
                ActualizarVistas();
                LimpiarCamposLibro();
            }
            else
            {
                MessageBox.Show("Seleccione un libro de la lista.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (nombreLibroSeleccionado != null && cbAutores.SelectedItem != null)
            {
                string nombreAutor = cbAutores.SelectedItem.ToString();
                Autor autorObj = autorDAO.Autores.Find(a => a.Nombre == nombreAutor);

                libroDAO.UpdateLibro(
                    nombreLibroSeleccionado,
                    tbNombreLibro.Text,
                    autorObj,
                    dtpLibroFecha.Value,
                    tbDescripcion.Text
                );

                ActualizarVistas();
                LimpiarCamposLibro();
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Libro libro = (Libro)dgvLibros.Rows[e.RowIndex].DataBoundItem;

                // Llenar campos
                tbNombreLibro.Text = libro.Nombre;
                dtpLibroFecha.Value = libro.FechaPublicacion;
                tbDescripcion.Text = libro.Descripcion;

                // Seleccionar el autor correcto en el ComboBox
                if (libro.Autor != null)
                {
                    cbAutores.SelectedItem = libro.Autor.Nombre;
                }

                nombreLibroSeleccionado = libro.Nombre;
            }
        }
        #endregion

        #region Métodos de búsqueda
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tbResultados.Clear();

            if (cbTipoBusqueda.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de búsqueda.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tipo = cbTipoBusqueda.SelectedItem.ToString();
            string termino = tbBusqueda.Text.Trim();

            if (!tipo.Contains("Extremos") && string.IsNullOrEmpty(termino))
            {
                MessageBox.Show("Ingrese un término de búsqueda.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. Selección del algoritmo
            switch (cbTipoBusqueda.SelectedIndex)
            {
                case 0: // Por Nombre de Libro (Lineal)
                    Libro libroEnc = BusquedaLineal.BuscarPorNombre(libroDAO, termino);
                    if (libroEnc != null)
                    {
                        ImprimirLibro(libroEnc);
                    }
                    else
                    {
                        tbResultados.Text = "No se encontró ningún libro con ese nombre exacto.";
                    }
                    break;

                case 1: // Por Nombre de Autor (Binaria)
                    Autor autorEnc = BusquedaBinaria.BuscarPorNombre(autorDAO, termino);
                    if (autorEnc != null)
                    {
                        tbResultados.Text = $"AUTOR ENCONTRADO:\nNombre: {autorEnc.Nombre}";
                    }
                    else
                    {
                        tbResultados.Text = "Autor no encontrado (recuerde escribir el nombre completo).";
                    }
                    break;

                case 2: // Libros Extremos
                    var resultado = BusquedaFechas.BuscarExtremos(libroDAO);
                    if (resultado != null)
                    {
                        tbResultados.AppendText("=== LIBRO MÁS ANTIGUO ===\n");
                        ImprimirLibro(resultado.Value.antiguo);
                        tbResultados.AppendText("\n=== LIBRO MÁS RECIENTE ===\n");
                        ImprimirLibro(resultado.Value.reciente);
                    }
                    else
                    {
                        tbResultados.Text = "No hay libros registrados para analizar.";
                    }
                    break;

                case 3: // En Descripciones
                    List<Libro> coincidencias = BusquedaTexto.BuscarEnDescripciones(libroDAO, termino);
                    if (coincidencias.Count > 0)
                    {
                        tbResultados.Text = $"Se encontraron {coincidencias.Count} coincidencias:\n\n";
                        foreach (var lib in coincidencias)
                        {
                            ImprimirLibro(lib);
                            tbResultados.AppendText("-------------------\n");
                        }
                    }
                    else
                    {
                        tbResultados.Text = "No se encontraron coincidencias en las descripciones.";
                    }
                    break;
            }
        }
        #endregion
    }
}
