using BusquedaLibros.DAO;
using BusquedaLibros.Models;
using System.Diagnostics;


namespace BusquedaLibros.Main
{
    internal class Program
    {
        public static AutorDAO autores = new AutorDAO();
        public static LibroDAO libros = new LibroDAO();

        #region funciones de editar listas
        static void AgregarAutor(string nombre)
        {
            autores.AgregarAutor(nombre);
        }
        static void EliminarAutor(string nombre)
        {
            autores.EliminarAutor(nombre);
        }
        static void ActualizarAutor(string nombreViejo, string nombreNuevo)
        {
            autores.UpdateAutor(nombreViejo, nombreNuevo);
        }
        static void AgregarLibro(string nombre, Autor autor, DateTime fecha, string descripcion)
        {
            libros.AgregarLibro(nombre, autor, fecha, descripcion);
        }
        static void EliminarLibro(string nombre)
        {
            libros.EliminarLibro(nombre);
        }
        static void ActualizarLibro(string nombreViejo, string nombreNuevo, Autor nuevoAutor, DateTime nuevaFecha, string nuevaDescripcion)
        {
            libros.UpdateLibro(nombreViejo, nombreNuevo, nuevoAutor, nuevaFecha, nuevaDescripcion);
        }
        #endregion
        static void ImprimirEditarListas()
        {
            Console.WriteLine("1. Añadir autor.");
            Console.WriteLine("2. Eliminar autor.");
            Console.WriteLine("3. Actualizar autor.");
            Console.WriteLine("4. Añadir libro.");
            Console.WriteLine("5. Eliminar libro.");
            Console.WriteLine("6. Actualizar libro.\n");
        }
        static void ImprimirFuncionesBusqueda()
        {
            Console.WriteLine("1. Búsqueda lineal en la lista de libros.");
            Console.WriteLine("2. Búsqueda binaria en la lista de autores.");
            Console.WriteLine("3. Buscar libro más reciente y más antiguo.");
            Console.WriteLine("4. Buscar coincidencia dentro de descripciones textuales.\n");
        }
        static void ImprimirMenu()
        {
            Console.WriteLine("1. Editar listas.");
            Console.WriteLine("2. Funciones de búsqueda.");
            Console.WriteLine("3. Salir.\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al mejor gestor de libros del ayer y hoy.");
            while (true)
            {
                Console.WriteLine("¿Qué quieres hacer?");
                ImprimirMenu();
                int opcion = 0;
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion < 1 || opcion > 3) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese un número entero y válido.");
                }

                switch (opcion)
                {
                    case 1:
                        ImprimirEditarListas();
                        Console.ReadLine();
                        break;
                    case 2:
                        ImprimirFuncionesBusqueda();
                        Console.ReadLine();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
