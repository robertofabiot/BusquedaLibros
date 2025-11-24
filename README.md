# Sistema de Búsqueda para Biblioteca Digital Estudiantil

Este repositorio contiene el prototipo inicial de un sistema de búsqueda para la **Biblioteca Digital Estudiantil**. El proyecto implementa algoritmos de búsqueda manuales en C# para localizar información eficiente sobre libros y autores, sirviendo como base para el aprendizaje de estructuras de datos y algoritmos.

## Objetivos

### Objetivo General
Aplicar conceptos fundamentales de búsqueda en estructuras de datos mediante la implementación manual de algoritmos, fomentando el trabajo colaborativo y la documentación académica.

### Objetivos Específicos del Proyecto
1. **Investigación y Diseño:** Comprender las diferencias y casos de uso entre búsqueda lineal y binaria.
2. **Implementación Técnica:** Desarrollar un módulo de consola en C# que permita:
   - Realizar búsquedas lineales en listas de objetos.
   - Realizar búsquedas binarias en listas ordenadas.
   - Analizar rangos de datos (búsqueda de máximos y mínimos).
   - Buscar patrones de texto dentro de descripciones (búsqueda manual carácter por carácter).
3. **Gestión de Datos:** Permitir la administración básica (CRUD) de Autores y Libros en memoria.

## Integrantes del equipo

* Roberto Fabio Tercero Membreño

## Instrucciones de uso

### Requisitos previos
* **SDK de .NET 8.0** o superior.
* Visual Studio 2022 o VS Code.

### Ejecución
1. Clona el repositorio o descarga el código fuente.
2. Abre la solución `BusquedaLibros.sln` en Visual Studio.
3. Compila y ejecuta el proyecto `BusquedaLibros`.

### Guía del Menú Principal
Al iniciar, el sistema cargará automáticamente un set de datos de prueba (autores como Gabriel García Márquez, J.K. Rowling, etc.).

El sistema cuenta con las siguientes opciones numéricas:

**1. Editar listas**
Permite gestionar la base de datos en memoria:
* Añadir, eliminar o actualizar **Autores**.
* Añadir, eliminar o actualizar **Libros** (requiere que el autor exista previamente).

**2. Funciones de búsqueda**
Acceso a los algoritmos implementados:
* **Búsqueda lineal:** Busca un libro por su nombre exacto recorriendo la lista secuencialmente.
* **Búsqueda binaria:** Ordena la lista de autores y busca un nombre específico dividiendo el conjunto de datos (algoritmo manual).
* **Libro más reciente/antiguo:** Recorre la lista para encontrar las fechas de publicación extremas (máximo y mínimo).
* **Búsqueda en descripciones:** Algoritmo de coincidencia de texto (manual, sin usar `.Contains`) para encontrar palabras clave dentro de las sinopsis de los libros.

**3. Ver autores y libros**
Imprime en consola el listado completo de autores y libros registrados actualmente en el sistema.

**4. Salir**
Cierra la aplicación.

**5. Apagar equipo**
*(Precaución)* Ejecuta un comando del sistema para apagar el ordenador inmediatamente.

---
*Proyecto desarrollado como parte del Caso de Estudio de Estructuras de Datos.*