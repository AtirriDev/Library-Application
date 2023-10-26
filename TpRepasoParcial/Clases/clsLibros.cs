using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data;

namespace TpRepasoParcial.Clases
{
    class clsLibros
    {
        // esta va a ser la clase principal donde trabajemos para lo solicitado 

        // solo cree otra clase con la tabla idioma por q tambien es necesaria . las otras 2 tablas no he creado clases
        // por q para lo que se piden no es necesario . En el contexto de un programa con mas funcionalidades si las crearia


        // Instanciamos los objetos para la coneccion a la base de datos 

        private OleDbConnection conexion = new OleDbConnection();// objeto coneccion
        private OleDbCommand comando = new OleDbCommand();// objeto comando 
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();// objeto adaptador 

        private String CadenadeConeccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";// aca ponemos la cadena q esta en el nobre de la base de datos 
        private String Tabla = "Libro"; // Nombre de la tabla en que vamos a trabajar  tal cual esta en la base de datos 

        // declaracion de datos para los reportes
       

        // declaracion de datos de la clase
        private  Int32 idLibro;
        private String Titulo ;
        private Int32 idAutor;
        private  String AñoEdicion;
        private String Pais;
        private Int32 idIdioma;
        private Int32 Cantidad;
        private Decimal Precio;

        public Int32 idlib
        {
            get { return idLibro; }
            set { idLibro = value; }
        }

        public String tit
        {
            get { return Titulo; }
            set { Titulo = value; }
        }
        public Int32 idau
        {
            get { return idAutor; }
            set { idAutor = value; }
        }
        public String año
        {
            get { return AñoEdicion; }
            set { AñoEdicion = value; }

        }
        private String pais
        {
            get { return Pais; }
            set { Pais = value; }

        }

        public Int32 cant
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }

        public Decimal importe
        {
            get { return Precio; }
            set { Precio = value; }
        }

        public void ListarGrilla(ComboBox Combo , DataGridView Grilla , Label CantidadLibros , Label TotalImporte) 
        {

            try
            {

                conexion.ConnectionString = CadenadeConeccion;
                conexion.Open();
                comando.Connection = conexion; // le damos la coneccion al comando 
                comando.CommandType = CommandType.TableDirect; // le indicamos de que forma vamos a trabar en este caso tabladirect
                comando.CommandText = Tabla; // le asignamos la variable tabla que tiene la tabla q vamos a utilizar

                adaptador = new OleDbDataAdapter(comando);// creamos el adaptador con el comando adentro

                DataSet DS = new DataSet();// creamos un  objeto dataset

                adaptador.Fill(DS, Tabla); // al adaptador con la propiedad fill le asignamos el data set y la tabla

                
               
               


                // aca empieza la logica de listado que tengamos que hacer 

                Grilla.Rows.Clear(); // limpiamos la grilla 
                Int32 totallibros = 0;
                Decimal totalImporte = 0;
                clsIdioma nomidioma = new clsIdioma();
                String Idioma;

                if (DS.Tables[Tabla].Rows.Count>0)// pregunta si la tabla tiene filas 
                {
                    Decimal PrecioTotal = 0;
                    //utilizamos un foreach con el objeto datarow para recorrer la tabla 
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Idioma = nomidioma.BuscarId(Convert.ToInt32(fila["IdIdioma"]));
                        
                        if ( Idioma == Combo.Text)
                        {
                            PrecioTotal = Convert.ToDecimal(fila["Cantidad"]) * Convert.ToDecimal(fila["Precio"]); ;
                            
                            Grilla.Rows.Add(fila["Titulo"],fila["Año"],fila["Cantidad"],fila["Precio"], PrecioTotal);
                            totallibros++;
                            
                            totalImporte = totalImporte + PrecioTotal;


                        }
                    }
                }

                CantidadLibros.Text = totallibros.ToString();
                TotalImporte.Text = totalImporte.ToString();


            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                conexion.Close();
            
            }
        
        
        
        
        }
        public void GenerarReporteTxt(ComboBox Combo , String RutaGuardado) 
        {

            try
            {
               
                conexion.ConnectionString = CadenadeConeccion;
                conexion.Open();
                comando.Connection = conexion; // le damos la coneccion al comando 
                comando.CommandType = CommandType.TableDirect; // le indicamos de que forma vamos a trabar en este caso tabladirect
                comando.CommandText = Tabla; // le asignamos la variable tabla que tiene la tabla q vamos a utilizar

                adaptador = new OleDbDataAdapter(comando);// creamos el adaptador con el comando adentro

                DataSet DS = new DataSet();// creamos un  objeto dataset

                adaptador.Fill(DS, Tabla); // al adaptador con la propiedad fill le asignamos el data set y la tabla
                // creamos el StreamWriter para escribir el reporte

                StreamWriter AD = new StreamWriter(RutaGuardado, false , Encoding.UTF8);

                // aca empieza la logica de listado que tengamos que hacer 

                // Titulo
                AD.WriteLine("Listado de Libros");
                AD.WriteLine("");
                AD.WriteLine("Libros en : " + Combo.Text);
                AD.WriteLine("");
                AD.Write("TITULO");
                AD.Write(";");
                AD.Write("Año");
                AD.Write(";");
                AD.Write("Cantidad");
                AD.Write(";");
                AD.Write("Precio");
                AD.Write(";");
                AD.WriteLine("Total Precio");
                


                Int32 totallibros = 0;
                Decimal totalImporte = 0;
                
                clsIdioma nomidioma = new clsIdioma();
                String Idioma;

                if (DS.Tables[Tabla].Rows.Count > 0)// pregunta si la tabla tiene filas 
                {
                    Decimal PrecioTotal = 0;
                    //utilizamos un foreach con el objeto datarow para recorrer la tabla 
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Idioma = nomidioma.BuscarId(Convert.ToInt32(fila["IdIdioma"]));

                        if (Idioma == Combo.Text)
                        {
                            PrecioTotal = Convert.ToDecimal(fila["Cantidad"]) * Convert.ToDecimal(fila["Precio"]); ;
                            
                            AD.Write(fila["TITULO"]);
                            AD.Write(";");
                            AD.Write(fila["Año"]);
                            AD.Write(";");
                            AD.Write(fila["Cantidad"]);
                            AD.Write(";");
                            AD.Write(fila["Precio"]);
                            AD.Write(";");
                            AD.WriteLine(PrecioTotal.ToString("N2"));
                            totallibros++;

                            totalImporte = totalImporte + PrecioTotal;


                        }
                    }
                }
                AD.WriteLine(";");
                AD.Write("Cantidad de libros:;;");
                AD.WriteLine(totallibros);
                AD.Write("Total Importe:;;");
                AD.WriteLine(totalImporte.ToString());


                AD.Close();
                AD.Dispose();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                
                conexion.Close();

            }





        }
        public void GenerarReporteCsv(ComboBox Combo,String RutaGuardado)
        {

            try
            {

                conexion.ConnectionString = CadenadeConeccion;
                conexion.Open();
                comando.Connection = conexion; // le damos la coneccion al comando 
                comando.CommandType = CommandType.TableDirect; // le indicamos de que forma vamos a trabar en este caso tabladirect
                comando.CommandText = Tabla; // le asignamos la variable tabla que tiene la tabla q vamos a utilizar

                adaptador = new OleDbDataAdapter(comando);// creamos el adaptador con el comando adentro

                DataSet DS = new DataSet();// creamos un  objeto dataset

                adaptador.Fill(DS, Tabla); // al adaptador con la propiedad fill le asignamos el data set y la tabla
                // creamos el StreamWriter para escribir el reporte

                StreamWriter AD = new StreamWriter(RutaGuardado, false, Encoding.UTF8);

                // aca empieza la logica de listado que tengamos que hacer 

                // Titulo
                AD.WriteLine("Listado de Libros");
                AD.WriteLine("");
                AD.WriteLine("Libros en : " + Combo.Text);
                AD.WriteLine("");
                AD.Write("TITULO");
                AD.Write(";");
                AD.Write("Año");
                AD.Write(";");
                AD.Write("Cantidad");
                AD.Write(";");
                AD.Write("Precio");
                AD.Write(";");
                AD.WriteLine("Total Precio");



                Int32 totallibros = 0;
                Decimal totalImporte = 0;

                clsIdioma nomidioma = new clsIdioma();
                String Idioma;

                if (DS.Tables[Tabla].Rows.Count > 0)// pregunta si la tabla tiene filas 
                {
                    Decimal PrecioTotal = 0;
                    //utilizamos un foreach con el objeto datarow para recorrer la tabla 
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Idioma = nomidioma.BuscarId(Convert.ToInt32(fila["IdIdioma"]));

                        if (Idioma == Combo.Text)
                        {
                            PrecioTotal = Convert.ToDecimal(fila["Cantidad"]) * Convert.ToDecimal(fila["Precio"]); ;

                            AD.Write(fila["TITULO"]);
                            AD.Write(";");
                            AD.Write(fila["Año"]);
                            AD.Write(";");
                            AD.Write(fila["Cantidad"]);
                            AD.Write(";");
                            AD.Write(fila["Precio"]);
                            AD.Write(";");
                            AD.WriteLine(PrecioTotal.ToString("N2"));
                            totallibros++;

                            totalImporte = totalImporte + PrecioTotal;


                        }
                    }
                }
                AD.WriteLine(";");
                AD.Write("Cantidad de libros:;;");
                AD.WriteLine(totallibros);
                AD.Write("Total Importe:;;");
                AD.WriteLine(totalImporte.ToString());


                AD.Close();
                AD.Dispose();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                conexion.Close();

            }





        }
    }
}
