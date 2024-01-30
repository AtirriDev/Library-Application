# App-Libreria
Proyecto de la facu , creación de una app para una biblioteca. Desarrollado usando C# .NET y manejo de base de datos.

Instrucciones Proyecto 

Desarrollar los procedimientos necesarios en Visual Studio para resolver el siguiente problema y definir todos los datos locales y globales utilizados en ellos.

Una biblioteca dispone de un sistema informático que utiliza para gestionar el stock de libros que tiene a la venta. Un módulo del sistema permite realizar diferentes tipos de consultas en pantalla e informes impresos. Los datos se almacenan en una base de datos con la siguiente estructura:

![captura BD app libreria](https://github.com/AtirriDev/Library-Application/assets/147408803/8f64be1e-2772-4c55-8cd4-92a256e3c745)

Es necesario desarrollar una ventana que permita al usuario consultar libros escritos en el idioma de su elección. La interfaz debe tener los siguientes elementos:

• Un cuadro combinado con los nombres de los idiomas. Cuando se muestra la ventana, debe llenarse con datos de la base de datos.


• Un botón de comando que genera un informe en pantalla de los libros correspondientes al idioma elegido.

• Una grilla donde se generará el informe. Debe tener las siguientes columnas:
o Título del libro.
o Año de publicación.
o Cantidad en Stock.
o Precio Unitario.
o Precio Total. Este valor se obtiene multiplicando el precio unitario por la cantidad.

• Una etiqueta que muestra el número de libros mostrados (número de filas).

• Una etiqueta que muestra la cantidad total de los libros listados. Este valor se obtiene sumando los montos que se muestran en la última columna del grid (Precio Total).

• Un botón de comando que exporta los datos mostrados a un archivo de texto llamado 'ReporteLibros.TXT'.

• Un botón de comando que exporta los datos mostrados a un archivo de texto llamado 'ReporteLibros.CSV'."

Imagen de la interfaz gráfica:



![Captura de pantalla app Libreria](https://github.com/AtirriDev/Library-Application/assets/147408803/e3c16535-98ad-4315-9684-77c5954ff470)
