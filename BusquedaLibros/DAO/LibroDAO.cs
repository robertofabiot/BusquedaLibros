using BusquedaLibros.Models;
using System;
using System.Collections.Generic;

namespace BusquedaLibros.DAO
{
    public class LibroDAO
    {
        private List<Libro> Libros = new List<Libro>();

        public void AgregarLibro(string nombre, Autor autor, DateTime fechaPublicacion, string descripcion)
        {
            Libro nuevoLibro = new Libro(nombre, autor, fechaPublicacion, descripcion);
            Libros.Add(nuevoLibro);
        }

        public bool EliminarLibro(string nombre)
        {
            bool resultado = false;

            for (int i = 0; i < Libros.Count; i++)
            {
                if (Libros[i].Nombre == nombre)
                {
                    Libros.RemoveAt(i);
                    resultado = true;
                    i--;
                }
            }

            return resultado;
        }

        public string GetLibros()
        {
            if (Libros.Count == 0)
                return "No hay libros registrados";

            string lista = Libros[0].Nombre;

            for (int i = 1; i < Libros.Count; i++)
            {
                lista += ", " + Libros[i].Nombre;
            }

            return lista;
        }

        public bool UpdateLibro(
            string nombreViejo,
            string nombreNuevo,
            Autor nuevoAutor,
            DateTime nuevaFecha,
            string nuevaDescripcion)
        {
            bool resultado = false;

            for (int i = 0; i < Libros.Count; i++)
            {
                if (Libros[i].Nombre == nombreViejo)
                {
                    Libros[i].Nombre = nombreNuevo;
                    Libros[i].Autor = nuevoAutor;
                    Libros[i].FechaPublicacion = nuevaFecha;
                    Libros[i].Descripcion = nuevaDescripcion;

                    resultado = true;
                }
            }

            return resultado;
        }

        public List<Libro> GetListaLibros()
        {
            return Libros;
        }
    }
}
