using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaLibros.GUI
{
    public class BusquedaLineal
    {
        public static Libro BuscarPorNombre(LibroDAO libros, string nombre)
        {
            for (int i = 0; i < libros.Libros.Count; i++)
            {
                if (libros.Libros[i].Nombre == nombre)
                {
                    return libros.Libros[i];
                }
            }
            return null;
        }
    }
}
