using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto
{
    public partial class frmMantenimientoServicios : Form
    {
        //Código del servicio adicional que desea el cliente.Valor numérico y llave primaria en la tabla.
        //Descripción del servicio.Solamente debe de aceptar letras y espacios.
        //Costo del servicio al día.
        //Los costos se determinan en el análisis al gusto.Para este sistema solamente estará habilitado los servicios GPS que el código será 1, silla para niños 2, asistencia en carretera 3 y 0 no contrada servicios adicionales.
        //Estos servicios, el cliente solamente podrá seleccionar uno en la reserva.
        string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";


        public frmMantenimientoServicios()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FileStream flujo; // para decir que concete la memoria con el disco duro

            //Variables
            archivo = "MantServicios.txt";

            try
            {
                Directory.CreateDirectory(ruta);
                flujo = File.Create(ruta + archivo); // 

                MessageBox.Show("Archivo con clases creado", "CREACION DE MANTENIMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        public void leerArchivo()
        {

            try
            {
                StreamReader leer = new StreamReader(ruta + archivo);

                string codServicio, descripPerfil;

                cargarListView();

                while (leer.Peek() != -1) //.pkeek trae ultima l[inea
                {
                    string linea = leer.ReadLine();
                    string[] separador = linea.Split(',');

                    codServicio = separador[0];
                    descripPerfil = separador[1];
                    

                    if (string.IsNullOrEmpty(linea))
                    {
                        continue;
                    }

                    lsvMantServicios.Items.Add(codServicio);
                    // lsvMantPersonas.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(descripPerfil);

                }

                leer.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        public void cargarListView()
        {
            lsvMantServicios.Clear();
            lsvMantServicios.Columns.Add("CODIGO SERVICIO").Width = 100;
            lsvMantServicios.Columns.Add("DESCRIPCION PERFIL").Width = 100;
           
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter escribir = new StreamWriter(ruta + archivo, true); // el true hace que grabe registro por registro

                if (File.Exists(ruta + archivo))
                {
                    if (txxtCódServicio.Text.Equals("") || txtDescripciónPerfil.Text.Equals(""))
                    {
                        MessageBox.Show("Datos incompletos completos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txxtCódServicio.Focus();
                    }
                    else
                    {
                        escribir.WriteLine(txxtCódServicio.Text + "," + txtDescripciónPerfil.Text);
                        escribir.Close();

                        MessageBox.Show("Datos del perro guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leerArchivo();
                    }
                }
                else
                {
                    MessageBox.Show("Ruta no existen", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmMantenimientoServicios_Load(object sender, EventArgs e)
        {

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            string archivoTemporal = "temp.txt";
            string linea;

            StreamReader leer = new StreamReader(ruta + archivo);
            StreamWriter escribir = new StreamWriter(ruta + archivoTemporal);

            if (txxtCódServicio.Text.Equals("") || txtDescripciónPerfil.Text.Equals(""))
            {
                MessageBox.Show("ingresar datos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txxtCódServicio.Focus();

            }
            else
            {
                while (leer.Peek() != -1) // vamos a hacer la lectura de la linea
                {
                    linea = leer.ReadLine();

                    string[] separador = linea.Split(',');

                    if (separador[0] != txxtCódServicio.Text || separador[1] != txtDescripciónPerfil.Text)
                    {
                        escribir.WriteLine(linea);
                    }
                }
                MessageBox.Show("Registro inhabilitado satisfactoriamente", "Inhabilitar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                leer.Close();
                escribir.Close();

                File.Delete(ruta + archivo);
                File.Move(ruta + archivoTemporal, ruta + archivo);

                leerArchivo();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form MenuPrincipal = new frmMenu();
            MenuPrincipal.Show();

            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
