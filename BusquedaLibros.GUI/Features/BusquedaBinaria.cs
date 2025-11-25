using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaLibros.GUI
{
    public class BusquedaBinaria
    {
        public static Autor BuscarPorNombre(AutorDAO autores, string nombre)
        {
            autores.Autores.Sort((x, y) => string.Compare(x.Nombre, y.Nombre, StringComparison.OrdinalIgnoreCase));

            int inicio = 0;
            int fin = autores.Autores.Count - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                string nombreMedio = autores.Autores[medio].Nombre;

                int comparacion = string.Compare(nombreMedio, nombre, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    return autores.Autores[medio];
                }
                else if (comparacion < 0)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return null;
        }
    }
}