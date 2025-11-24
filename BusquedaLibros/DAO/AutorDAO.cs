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
        private void AgregarAutor(string nombre)
        {
            Autor nuevoAutor = new Autor(nombre);
            Autores.Add(nuevoAutor);
        }

        private bool EliminarAutor(string nombre)
        {
            bool resultado = false;
            Autor autorEliminado = new Autor(nombre);
            for (int i = 0; i < Autores.Count; i++)
            {
                if (Autores[i].Nombre == nombre)
                {
                    Autores.Remove(autorEliminado);
                    resultado = true;
                }
            }
            return resultado;
        }
        private string GetAutores()
        {
            string autores = "";
            for (int i = 0; i < Autores.Count; i++)
            {

            }
        }
    }
}
