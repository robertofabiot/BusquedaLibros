using BusquedaLibros.DAO;
using BusquedaLibros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaLibros.Main
{
    public class BusquedaLineal
    {
        public static bool BuscarPorNombre(LibroDAO libros, string nombre)
        {
            bool resultado = false;
            for (int i = 0; i < libros.Libros.Count; i++)
            {
                if (libros.Libros[i].Nombre == nombre)
                {
                    Console.WriteLine($"Encontrado en la posición {i}");
                    resultado = true;
                }
            }
            return resultado;
        }
    }
}
