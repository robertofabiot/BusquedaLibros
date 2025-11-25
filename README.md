# Sistema de Gestión y Búsqueda de Libros

Este repositorio aloja una solución integral para la gestión bibliográfica estudiantil, implementando algoritmos de búsqueda y estructuras de datos fundamentales. El proyecto ahora cuenta con **dos interfaces de usuario**: una aplicación de consola clásica (Legacy) y una nueva interfaz gráfica moderna (Windows Forms).

## Características Principales

### Nueva Interfaz Gráfica (GUI)
El proyecto ha evolucionado para incluir una aplicación de escritorio basada en **Windows Forms (.NET Framework 4.7.2)** que ofrece:
* **Gestión Visual (CRUD):** Tablas interactivas para agregar, editar y eliminar Libros y Autores.
* **Pestañas de Navegación:** Separación clara entre la gestión de datos y las operaciones de búsqueda.
* **Visualización de Resultados:** Cuadros de texto enriquecidos para mostrar detalles de las búsquedas.
* **Controles Dinámicos:** Selección de autores mediante listas desplegables y calendarios para fechas.

### Versión de Consola (Legacy)
Se conserva la versión original en **.NET 8.0** para fines educativos y de análisis de rendimiento, permitiendo la ejecución de los algoritmos en un entorno de texto puro.

### Algoritmos Implementados
El núcleo lógico del sistema aplica manualmente los siguientes algoritmos (sin depender de librerías de alto nivel para la búsqueda):

1.  **Búsqueda Lineal:** Localización secuencial de libros por título exacto.
2.  **Búsqueda Binaria:** Localización eficiente de autores (requiere ordenamiento previo de la lista).
3.  **Análisis de Extremos:** Algoritmo de recorrido único para identificar el libro más antiguo y el más reciente simultáneamente.
4.  **Búsqueda de Texto (String Matching):** Algoritmo de fuerza bruta (carácter por carácter) para encontrar patrones dentro de las descripciones de los libros.

## Estructura de la Solución

La solución `BusquedaLibros.sln` contiene dos proyectos independientes:

| Proyecto | Tipo | Framework | Descripción |
| :--- | :--- | :--- | :--- |
| **`BusquedaLibros`** | Consola | .NET 8.0 | Prototipo inicial y lógica base. |
| **`BusquedaLibros.GUI`** | WinForms | .NET Fx 4.7.2 | Interfaz gráfica de usuario final. |

## Requisitos Previos

* **Visual Studio 2022** (Recomendado) o VS Code.
* **SDK de .NET 8.0** (Para la consola).
* **Herramientas de desarrollo de escritorio de .NET** (Para Windows Forms).

## Instrucciones de Ejecución

1.  **Clonar el repositorio:**
    ```bash
    git clone https://github.com/robertofabiot/BusquedaLibros
    ```
2.  **Abrir la solución:** Ejecuta el archivo `BusquedaLibros.sln`.

### Cómo cambiar entre GUI y Consola
En Visual Studio, el proyecto que se ejecuta al presionar `F5` es el que está marcado en **negrita**. Para cambiarlo:

1.  Haz clic derecho sobre el proyecto que deseas ejecutar (por ejemplo, `BusquedaLibros.GUI`).
2.  Selecciona la opción **"Establecer como proyecto de inicio" (Set as Startup Project)**.
3.  Presiona **Iniciar** o `F5`.

## Guía de Uso (Interfaz Gráfica)

### Pestaña Gestión
* **Autores:** Agrega autores primero. Puedes editarlos o eliminarlos seleccionándolos de la tabla superior.
* **Libros:** Para agregar un libro, selecciona un autor existente del menú desplegable, llena los datos y haz clic en "Agregar".

### Pestaña Búsqueda
Selecciona el algoritmo deseado en el menú superior:
1.  **Por Nombre de Libro:** Escribe el título exacto.
2.  **Por Nombre de Autor:** Escribe el nombre (usa búsqueda binaria interna).
3.  **Libros Extremos:** Muestra el libro más viejo y el más nuevo registrados.
4.  **En Descripciones:** Escribe una palabra clave (ej. "magia") para buscar en las sinopsis.

## Integrantes del Equipo

* **Roberto Fabio Tercero Membreño**

Proyecto desarrollado con fines académicos para la asignatura de Programación Estructurada.
