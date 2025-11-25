using System;
using System.Collections.Generic;

namespace BusquedaLibros.GUI
{
    public class AutorDAO
    {
        public List<Autor> Autores = new List<Autor>();

        public void AgregarAutor(string nombre)
        {
            Autor nuevoAutor = new Autor(nombre);
            Autores.Add(nuevoAutor);
        }

        public bool EliminarAutor(string nombre)
        {
            bool resultado = false;

            for (int i = 0; i < Autores.Count; i++)
            {
                if (Autores[i].Nombre == nombre)
                {
                    Autores.RemoveAt(i);   
                    resultado = true;
                    i--;                   
                }
            }

            return resultado;
        }

        public string GetAutores()
        {
            if (Autores.Count == 0)
                return "No hay autores registrados";

            string autores = Autores[0].Nombre;

            for (int i = 1; i < Autores.Count; i++)
            {
                autores += ", " + Autores[i].Nombre;
            }

            return autores;
        }

        public bool UpdateAutor(string nombreViejo, string nombreNuevo)
        {
            bool resultado = false;

            for (int i = 0; i < Autores.Count; i++)
            {
                if (Autores[i].Nombre == nombreViejo)
                {
                    Autores[i].Nombre = nombreNuevo;
                    resultado = true;
                }
            }

            return resultado;
        }
    }
}
