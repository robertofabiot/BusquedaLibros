using BusquedaLibros.DAO;
using BusquedaLibros.Models;
using System.Diagnostics;


namespace BusquedaLibros.Main
{
    internal class Program
    {
        public static AutorDAO autores = new AutorDAO();
        public static LibroDAO libros = new LibroDAO();
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
                                Console.Write("Ingrese el nombre del nuevo autor: ");
                                // Solución 2: Si ReadLine es null, asignamos "" (string.Empty)
                                string nombreAutorAdd = Console.ReadLine() ?? string.Empty;

                                if (string.IsNullOrWhiteSpace(nombreAutorAdd))
                                {
                                    Console.WriteLine("Error: El nombre no puede estar vacío.");
                                }
                                else
                                {
                                    autores.AgregarAutor(nombreAutorAdd);
                                    Console.WriteLine("Éxito: Autor agregado correctamente.");
                                }
                                break;

                            case 2: // Eliminar autor
                                Console.Write("Ingrese el nombre del autor a eliminar: ");
                                string nombreAutorDel = Console.ReadLine() ?? string.Empty;

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
                                Console.Write("Ingrese el nombre del autor a editar: ");
                                string nombreViejoA = Console.ReadLine() ?? string.Empty;
                                Console.Write("Ingrese el nuevo nombre: ");
                                string nombreNuevoA = Console.ReadLine() ?? string.Empty;

                                if (string.IsNullOrWhiteSpace(nombreNuevoA))
                                {
                                    Console.WriteLine("Error: El nuevo nombre no puede estar vacío.");
                                }
                                else if (autores.UpdateAutor(nombreViejoA, nombreNuevoA))
                                {
                                    Console.WriteLine("Éxito: Autor actualizado.");
                                }
                                else
                                {
                                    Console.WriteLine("Error: No se encontró el autor original.");
                                }
                                break;

                            case 4: // Añadir libro
                                Console.Write("Nombre del libro: ");
                                string nombreLibroAdd = Console.ReadLine() ?? string.Empty;
                                if (string.IsNullOrWhiteSpace(nombreLibroAdd))
                                {
                                    Console.WriteLine("Error: El nombre del libro es obligatorio.");
                                    break;
                                }

                                Console.Write("Nombre del Autor (debe existir previamente): ");
                                string nombreAutorLibro = Console.ReadLine() ?? string.Empty;

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

                                Console.Write("Descripción del libro: ");
                                string descLibro = Console.ReadLine() ?? string.Empty;

                                libros.AgregarLibro(nombreLibroAdd, autorEncontrado, fechaLibro, descLibro);
                                Console.WriteLine(">> Éxito: Libro agregado correctamente.");
                                break;

                            case 5: // Eliminar libro
                                Console.Write("Ingrese el nombre del libro a eliminar: ");
                                string nombreLibroDel = Console.ReadLine() ?? string.Empty;

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
                                Console.Write("Nombre del libro a editar: ");
                                string nombreLibroOld = Console.ReadLine() ?? string.Empty;

                                Console.WriteLine("Ingrese los Nuevos Datos");
                                Console.Write("Nuevo Nombre: ");
                                string nombreLibroNew = Console.ReadLine() ?? string.Empty;

                                Console.Write("Nuevo Autor: ");
                                string nombreAutorNew = Console.ReadLine() ?? string.Empty;

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

                                Console.Write("Nueva Descripción: ");
                                string descNew = Console.ReadLine() ?? string.Empty;

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
                        break;
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
                            case 1: // Búsqueda lineal en una lista de libros
                                Console.WriteLine("Ingresa el nombre del libro a buscar: ");
                                string ?nombre = Console.ReadLine();

                                if (nombre == null)
                                {
                                    Console.WriteLine("Entrada inválida.");
                                    break;
                                }

                                nombre = nombre.Trim();

                                // Validación: vacío o solo espacios
                                if (nombre == "")
                                {
                                    Console.WriteLine("Debes ingresar un nombre.");
                                    break;
                                }

                                // Validación: lista nula o vacía
                                if (libros == null || libros.Libros.Count == 0)
                                {
                                    Console.WriteLine("No hay libros registrados.");
                                    break;
                                }

                                // Llamada a la función real
                                if (!BusquedaLineal.BuscarPorNombre(libros, nombre))
                                {
                                    Console.WriteLine("No encontrado.");
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
