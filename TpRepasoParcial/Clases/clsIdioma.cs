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
    class clsIdioma
    {
        // Instanciamos los objetos para la coneccion a la base de datos 

        private OleDbConnection conexion = new OleDbConnection();// objeto coneccion
        private OleDbCommand comando = new OleDbCommand();// objeto comando 
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();// objeto adaptador 

        private String CadenadeConeccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";// aca ponemos la cadena q esta en el nobre de la base de datos 
        private String Tabla = "Idioma"; // Nombre de la tabla en que vamos a trabajar  tal cual esta en la base de datos 

        private Int32 idIdioma;
        private String NombreIdioma;

        public Int32 idlengua
        {
            get { return idIdioma; }
            set { idIdioma = value; }
        }
        public String lengua
        {
            get { return NombreIdioma; }
            set { NombreIdioma = value; }
        }


        public void LlenarComboBox(ComboBox Combo)
        {
            try
            {
                conexion.ConnectionString = CadenadeConeccion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                Combo.DataSource = DS.Tables[Tabla];
                Combo.DisplayMember = "Nombre"; // aca ponemos lo que queremos que se vea en el combo
                Combo.ValueMember = "IdIdioma"; // aca el campo de la tabla que tiene identificador 

               

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

        public String BuscarId( Int32 idIdioma) 
        {

            try
            {
                conexion.ConnectionString = CadenadeConeccion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();// UTILIZAREMOS ESTO PARA LEER
                String resultado = "";
               
                if (DR.HasRows)// Aaca preguntamos si el objeto Dr que es un rata reader tiene filas 
                {
                    while (DR.Read())// como siempre usaremos un while para busqueda , Mientras el Dr lea dice en los ()
                    {
                        // si el id del idioma en la base de datos es igual al que se le pasa por parametro lo capturamos
                        //en la variable resultado
                        if (DR.GetInt32(0)== idIdioma) 
                        {
                            resultado = DR.GetString(1);
                        }
                    }
                }


                return resultado;

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
