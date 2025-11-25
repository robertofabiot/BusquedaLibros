using System;
using System.Collections.Generic;
using BusquedaLibros.GUI; 

namespace BusquedaLibros.GUI
{
    public class BusquedaFechas
    {
        // Devuelve dos libros: (MasAntiguo, MasReciente)
        public static (Libro antiguo, Libro reciente)? BuscarExtremos(LibroDAO libros)
        {
            if (libros.Libros.Count == 0) return null;

            Libro masReciente = libros.Libros[0];
            Libro masAntiguo = libros.Libros[0];

            foreach (var libro in libros.Libros)
            {
                if (libro.FechaPublicacion > masReciente.FechaPublicacion)
                    masReciente = libro;

                if (libro.FechaPublicacion < masAntiguo.FechaPublicacion)
                    masAntiguo = libro;
            }

            return (masAntiguo, masReciente);
        }
    }
}