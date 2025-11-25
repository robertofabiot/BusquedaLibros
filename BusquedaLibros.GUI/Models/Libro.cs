using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaLibros.GUI
    public class Libro
    {
        public string Nombre { get; set; }
        public Autor Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Descripcion { get; set; }
        public Libro(string nombre, Autor autor, DateTime fechaPublicacion, string descripcion)
        {
            this.Nombre = nombre;
            this.Autor = autor;
            this.FechaPublicacion = fechaPublicacion;
            this.Descripcion = descripcion;
        }
    }
}
