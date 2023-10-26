using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpRepasoParcial.Clases;
using System.Runtime.InteropServices;

namespace TpRepasoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsIdioma x = new clsIdioma();
            x.LlenarComboBox(cmbiIdiomas);
             
            
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            clsLibros x = new clsLibros();
            x.ListarGrilla(cmbiIdiomas, dgvLibros, lblCantidadLibros,lblTotalImporte);
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private DateTime ultimoClic = DateTime.Now;
        private void cmdReportes_Click(object sender, EventArgs e)
        {
            cmdReporteCsv.Visible = true;
            cmdReporteTxt.Visible = true;
            // Calcula la diferencia de tiempo desde el último clic.
            TimeSpan diferencia = DateTime.Now - ultimoClic;

            // Si la diferencia de tiempo es menor que un cierto valor (por ejemplo, 500 milisegundos), considera que es un doble clic.
            if (diferencia.TotalMilliseconds < 500)
            {
                // Realiza la acción que deseas cuando se haga doble clic en el botón.
                cmdReporteCsv.Visible = false;
                cmdReporteTxt.Visible = false;
            }

            // Actualiza el tiempo del último clic.
            ultimoClic = DateTime.Now;
        }

        private void cmdReporteTxt_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Guardar Reporte";
                saveFileDialog1.Filter = "Archivo de texto (.txt)|*.txt";
                if (saveFileDialog1.ShowDialog()== DialogResult.OK)
                {
                   
                    clsLibros reporte = new clsLibros();
                    reporte.GenerarReporteTxt(cmbiIdiomas,saveFileDialog1.FileName);
                    MessageBox.Show("Reporte generado exitosamente");
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas para guardar el archivo ");
            }
            
            
        }

        private void cmdReporteCsv_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Guardar Reporte";
                saveFileDialog1.Filter = "Archivo de texto (.csv)|*.csv";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    clsLibros reporte = new clsLibros();
                    reporte.GenerarReporteCsv(cmbiIdiomas, saveFileDialog1.FileName);
                    MessageBox.Show("Reporte generado exitosamente");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Problemas para guardar el archivo ");
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // evento para poder mover el formulario aunque no tengamos bordes 

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            // evento para poder mover el formulario aunque no tengamos bordes 

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
