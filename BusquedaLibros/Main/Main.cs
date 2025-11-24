using BusquedaLibros.DAO;
using BusquedaLibros.Models;
using System.Diagnostics;


namespace BusquedaLibros.Main
{
    internal class Program
    {
        public static AutorDAO autores = new AutorDAO();
        public static LibroDAO libros = new LibroDAO();
        static void CargarPorDefecto()
        {
            Autor? autor; // Variable auxiliar reutilizable

            // 1. Gabriel García Márquez
            autores.AgregarAutor("Gabriel García Márquez");
            autor = autores.Autores.Find(a => a.Nombre == "Gabriel García Márquez");
            if (autor != null)
            {
                libros.AgregarLibro("Cien años de soledad", autor, new DateTime(1967, 5, 30), "Obra maestra del realismo mágico.");
                libros.AgregarLibro("El amor en los tiempos del cólera", autor, new DateTime(1985, 1, 1), "Historia de amor.");
            }

            // 2. J.K. Rowling
            autores.AgregarAutor("J.K. Rowling");
            autor = autores.Autores.Find(a => a.Nombre == "J.K. Rowling");
            if (autor != null)
            {
                libros.AgregarLibro("Harry Potter y la piedra filosofal", autor, new DateTime(1997, 6, 26), "Magia y aventuras.");
            }

            // 3. George Orwell
            autores.AgregarAutor("George Orwell");
            autor = autores.Autores.Find(a => a.Nombre == "George Orwell");
            if (autor != null)
            {
                libros.AgregarLibro("1984", autor, new DateTime(1949, 6, 8), "Novela distópica sobre el control social.");
                libros.AgregarLibro("Rebelión en la granja", autor, new DateTime(1945, 8, 17), "Sátira política.");
            }

            // 4. Isaac Asimov
            autores.AgregarAutor("Isaac Asimov");
            autor = autores.Autores.Find(a => a.Nombre == "Isaac Asimov");
            if (autor != null)
            {
                libros.AgregarLibro("Yo, Robot", autor, new DateTime(1950, 12, 2), "Colección de relatos sobre robótica.");
            }

            Console.WriteLine(">> Datos iniciales cargados correctamente.\n");
        }
        static string PedirTexto(string mensaje)
        {
            string entrada;
            do
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine()?.Trim() ?? "";
                if (string.IsNullOrEmpty(entrada))
                {
                    Console.WriteLine(">> Error: El campo no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(entrada));

            return entrada;
        }
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
        static void VerAutoresYLibros()
        {
            Console.WriteLine("=== Autores ===");
            if (autores?.Autores == null || autores.Autores.Count == 0)
            {
                Console.WriteLine("No hay autores en la lista.");
            }
            else
            {
                Console.WriteLine($"Total autores: {autores.Autores.Count}");
                int i = 1;
                foreach (var a in autores.Autores)
                {
                    string nombre = a?.Nombre ?? "(nombre nulo)";
                    Console.WriteLine($"{i}. {nombre}");
                    i++;
                }
            }

            Console.WriteLine(); // separación

            Console.WriteLine("=== Libros ===");
            var listaLibros = libros?.Libros ?? libros?.GetListaLibros();
            if (listaLibros == null || listaLibros.Count == 0)
            {
                Console.WriteLine("No hay libros en la lista.");
            }
            else
            {
                Console.WriteLine($"Total libros: {listaLibros.Count}");
                int j = 1;
                foreach (var lib in listaLibros)
                {
                    string nombreLibro = lib?.Nombre ?? "(nombre nulo)";
                    string autorNombre = lib?.Autor?.Nombre ?? "(autor no asignado)";
                    string fecha = lib != null ? lib.FechaPublicacion.ToString("yyyy-MM-dd") : "(fecha nula)";
                    string descripcion = lib?.Descripcion ?? string.Empty;

                    Console.WriteLine($"--- Libro {j} ---");
                    Console.WriteLine($"Nombre: {nombreLibro}");
                    Console.WriteLine($"Autor: {autorNombre}");
                    Console.WriteLine($"Fecha de publicación: {fecha}");
                    Console.WriteLine($"Descripción: {descripcion}");
                    j++;
                }
            }

            Console.WriteLine(); // espacio final
        }
        static void ImprimirMenu()
        {
            Console.WriteLine("1. Editar listas.");
            Console.WriteLine("2. Funciones de búsqueda.");
            Console.WriteLine("3. Ver autores y libros.");
            Console.WriteLine("4. Salir.");
            Console.WriteLine("5. Apagar equipo.\n");
        }

        static void Main(string[] args)
        {
            CargarPorDefecto();
            Console.WriteLine("Bienvenido al mejor gestor de libros del ayer y hoy.");
            while (true)
            {
                Console.WriteLine("¿Qué quieres hacer?");
                ImprimirMenu();
                int opcion = 0;
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion < 1 || opcion > 5) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese un número entero y válido.");
                }

                switch (opcion)
                {
                    case 1:
                        ImprimirEditarListas();
                        int opcionListas = 0;
                        try
                        {
                            Console.Write("Seleccione una opción: ");
                            opcionListas = Convert.ToInt32(Console.ReadLine() ?? "0");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Por favor ingrese un número válido.");
                            break;
                        }

                        switch (opcionListas)
                        {
                            case 1: // Añadir autor
                                string nombreAutorAdd = PedirTexto("Ingrese el nombre del nuevo autor: ");
                                autores.AgregarAutor(nombreAutorAdd);
                                Console.WriteLine("Éxito: Autor agregado correctamente.");
                                break;

                            case 2: // Eliminar autor
                                string nombreAutorDel = PedirTexto("Ingrese el nombre del autor a eliminar: ");

                                if (autores.EliminarAutor(nombreAutorDel))
                                {
                                    Console.WriteLine("Éxito: Autor eliminado.");
                                }
                                else
                                {
                                    Console.WriteLine("Error: No se encontró un autor con ese nombre.");
                                }
                                break;

                            case 3: // Actualizar autor
                                string nombreViejoA = PedirTexto("Ingrese el nombre del autor a editar: ");
                                string nombreNuevoA = PedirTexto("Ingrese el nuevo nombre: ");

                                if (autores.UpdateAutor(nombreViejoA, nombreNuevoA))
                                {
                                    Console.WriteLine("Éxito: Autor actualizado.");
                                }
                                else
                                {
                                    Console.WriteLine("Error: No se encontró el autor original.");
                                }
                                break;

                            case 4: // Añadir libro
                                string nombreLibroAdd = PedirTexto("Nombre del libro: ");
                                string nombreAutorLibro = PedirTexto("Nombre del Autor (debe existir previamente): ");

                                Autor? autorEncontrado = autores.Autores.Find(a => a.Nombre.Equals(nombreAutorLibro, StringComparison.OrdinalIgnoreCase));

                                if (autorEncontrado == null)
                                {
                                    Console.WriteLine("Error: El autor no existe. Agréguelo primero en la opción 1.");
                                    break;
                                }

                                Console.Write("Fecha de publicación (formato aaaa-mm-dd): ");
  
                                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fechaLibro))
                                {
                                    Console.WriteLine("Error: Formato de fecha inválido.");
                                    break;
                                }

                                string descLibro = PedirTexto("Descripción del libro: ");

                                libros.AgregarLibro(nombreLibroAdd, autorEncontrado, fechaLibro, descLibro);
                                Console.WriteLine(">> Éxito: Libro agregado correctamente.");
                                break;

                            case 5: // Eliminar libro
                                string nombreLibroDel = PedirTexto("Ingrese el nombre del libro a eliminar: ");

                                if (libros.EliminarLibro(nombreLibroDel))
                                {
                                    Console.WriteLine("Éxito: Libro eliminado.");
                                }
                                else
                                {
                                    Console.WriteLine("Error: No se encontró el libro.");
                                }
                                break;

                            case 6: // Actualizar libro
                                string nombreLibroOld = PedirTexto("Nombre del libro a editar: ");

                                Console.WriteLine("Ingrese los Nuevos Datos");
                                string nombreLibroNew = PedirTexto("Nuevo Nombre: ");
                                string nombreAutorNew = PedirTexto("Nuevo Autor: ");

                                Autor? autorNewObj = autores.Autores.Find(a => a.Nombre.Equals(nombreAutorNew, StringComparison.OrdinalIgnoreCase));

                                if (autorNewObj == null)
                                {
                                    Console.WriteLine(">> Error: El nuevo autor no existe.");
                                    break;
                                }

                                Console.Write("Nueva Fecha (aaaa-mm-dd): ");
                                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fechaNew))
                                {
                                    Console.WriteLine(">> Error: Fecha inválida.");
                                    break;
                                }

                                string descNew = PedirTexto("Nueva Descripción: ");

                                if (libros.UpdateLibro(nombreLibroOld, nombreLibroNew, autorNewObj, fechaNew, descNew))
                                {
                                    Console.WriteLine(">> Éxito: Libro actualizado.");
                                }
                                else
                                {
                                    Console.WriteLine(">> Error: No se encontró el libro original para actualizar.");
                                }
                                break;

                            default:
                                Console.WriteLine("Opción no reconocida.");
                                break;
                        }
                        break; // Break del case 1 principal

                    case 2:
                        ImprimirFuncionesBusqueda();
                        int opcionBusqueda = 0;
                        try
                        {
                            Console.Write("Seleccione una opción: ");
                            opcionBusqueda = Convert.ToInt32(Console.ReadLine() ?? "0");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Por favor ingrese un número válido.");
                            break;
                        }

                        switch (opcionBusqueda)
                        {
                            case 1: // Búsqueda lineal
                                string nombre = PedirTexto("Ingresa el nombre del libro a buscar: ");

                                if (libros == null || libros.Libros.Count == 0)
                                {
                                    Console.WriteLine("No hay libros registrados.");
                                    break;
                                }

                                if (!BusquedaLineal.BuscarPorNombre(libros, nombre))
                                {
                                    Console.WriteLine("No encontrado.");
                                }
                                break;

                            case 2: // Búsqueda binaria en lista de autores
                                string nombreAutor = PedirTexto("Ingresa el nombre del autor a buscar: ");

                                if (autores == null || autores.Autores.Count == 0)
                                {
                                    Console.WriteLine("No hay autores registrados.");
                                    break;
                                }

                                if (!BusquedaBinaria.BuscarPorNombre(autores, nombreAutor))
                                {
                                    Console.WriteLine("Autor no encontrado.");
                                }
                                break;
                        }
                        break;

                    case 3:
                        VerAutoresYLibros();
                        Console.ReadLine(); 
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    case 5:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "shutdown",
                            Arguments = "/s /t 0",
                            CreateNoWindow = true,
                            UseShellExecute = false
                        });
                        break;
                }
            }
        }
    }
}
