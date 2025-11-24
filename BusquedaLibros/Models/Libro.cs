using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaLibros.Models
{
    public class Libro
    {
        public required string Nombre { get; set; }
        public required Autor Autor { get; set; }
        public required DateTime FechaPublicacion { get; set; }
        public required string Descripcion { get; set; }
    }
}
