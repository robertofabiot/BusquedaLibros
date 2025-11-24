using BusquedaLibros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusquedaLibros.DAO
{
    public class AutorDAO
    {
        private List<Autor> Autores = new List<Autor>();
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
                    Autores.Remove(Autores[i]);
                    resultado = true;
                }
            }
            return resultado;
        }
        public string GetAutores()
        {
            if (Autores.Count == 0) return "";
            string autores = Autores[0].Nombre;
            for (int i = 1; i < Autores.Count; i++)
            {
                autores += " ," + Autores[i].Nombre;
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
