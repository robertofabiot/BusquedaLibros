using System;
using System.Collections.Generic;
using BusquedaLibros.GUI;

namespace BusquedaLibros.GUI
{
    public class BusquedaTexto
    {
        public static List<Libro> BuscarEnDescripciones(LibroDAO libros, string termino)
        {
            List<Libro> encontrados = new List<Libro>();

            foreach (var libro in libros.Libros)
            {
                // Usamos el algoritmo manual que tenías en consola
                if (ContieneManual(libro.Descripcion, termino))
                {
                    encontrados.Add(libro);
                }
            }
            return encontrados;
        }

        private static bool ContieneManual(string textoFuente, string textoBusqueda)
        {
            if (string.IsNullOrEmpty(textoFuente) || string.IsNullOrEmpty(textoBusqueda)) return false;
            if (textoBusqueda.Length > textoFuente.Length) return false;

            for (int i = 0; i <= textoFuente.Length - textoBusqueda.Length; i++)
            {
                bool coincidencia = true;
                for (int j = 0; j < textoBusqueda.Length; j++)
                {
                    char charFuente = char.ToLower(textoFuente[i + j]);
                    char charBusqueda = char.ToLower(textoBusqueda[j]);

                    if (charFuente != charBusqueda)
                    {
                        coincidencia = false;
                        break;
                    }
                }
                if (coincidencia) return true;
            }
            return false;
        }
    }
}