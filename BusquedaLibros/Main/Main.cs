using BusquedaLibros.DAO;

namespace BusquedaLibros.Main
{
    internal class Program
    {
        static void ImprimirMenu()
        {
            Console.WriteLine("1. Búsqueda lineal en la lista de libros.");
            Console.WriteLine("2. Búsqueda binaria en la lista de autores.");
            Console.WriteLine("3. Buscar libro más reciente y más antiguo.");
            Console.WriteLine("4. Buscar coincidencia dentro de descripciones textuales.");
        }
        static void Main(string[] args)
        {

        }
    }
}
